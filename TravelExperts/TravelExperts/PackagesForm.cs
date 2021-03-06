﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts
{
    public partial class PackagesForm : Form
    {
        // GLOBALVARIABLE WHICH CHECKS IF IT IS A NEW FORM
        bool itIsNewForm = true;
        bool useCancelButton = false;
        bool useSaveButton = false;
        bool packageHasImage = false;
        // Valiables to work with image
        string newFileName = null;

        // List of ProdSuppliers Ids needed for updating form
        List<int> prodSuppliersIdForUpDate = new List<int>();

        public PackagesForm(DataGridViewRow rowstring)
        {
            InitializeComponent();

            // Assign values passed from another form
            if (rowstring != null)
            {
                txtId.Text = string.Format("{0}", rowstring.Cells[0].Value);
                txtName.Text = string.Format("{0}", rowstring.Cells[1].Value);
                tpStartDate.Text = string.Format("{0}", rowstring.Cells[2].Value);
                tpEndDate.Text = string.Format("{0}", rowstring.Cells[3].Value);
                txtDesc.Text = string.Format("{0}", rowstring.Cells[4].Value);
                txtBasePrice.Text = string.Format("{0:n}", rowstring.Cells[5].Value);
                txtAgComm.Text = string.Format("{0:n}", rowstring.Cells[6].Value);

                if (rowstring.Cells[7].Value != "" && rowstring.Cells[7].Value != System.DBNull.Value)
                {
                    newFileName = string.Format("{0}", rowstring.Cells[7].Value);
                    imgDescription.Text = newFileName;
                    imgDescription.BackColor = Color.White;
                    imgDescription.ForeColor = Color.Gray;
                    imgDescription.BorderStyle = BorderStyle.None;
                    // Button
                    btnManipulImage.Text = "X";
                    // Image
                    imgPackage.Image = Image.FromFile(Constants.IMAGESPATH + newFileName);

                    // Variable
                    packageHasImage = true;
                }
                else {
                    imgDescription.Text = "";
                    imgDescription.BackColor = Color.White;
                    imgDescription.BorderStyle = BorderStyle.FixedSingle;
                    // Image
                    imgPackage.Image = null;
                    // button
                    btnManipulImage.Text = "...";

                    packageHasImage = false;
                }

                itIsNewForm = false;
            }
        }

        //*******************************************************************************//
        //  PART NEEDED TO CREATE A USER CUSTOM CONTROL
        //*******************************************************************************//
        // Create new control
        TextAndButtonControlPackForm txtbtn = new TextAndButtonControlPackForm();
        // Number of the COLUMN which to apply custom control
        int colIndex = 0;

        void dgv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == colIndex && e.RowIndex > -1 && e.RowIndex != this.dgvPackProdSuppl.NewRowIndex)
            {
                Rectangle rect = this.dgvPackProdSuppl.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                this.txtbtn.Location = rect.Location;
                this.txtbtn.Size = rect.Size;
                this.txtbtn.Text = this.dgvPackProdSuppl.CurrentCell.Value.ToString();
                // Retreive whole ROW where click happened
                this.txtbtn.rowString = this.dgvPackProdSuppl.CurrentRow;
                // Retreive whole data Grid View
                this.txtbtn.dataGridView = this.dgvPackProdSuppl;

                this.txtbtn.ButtonText = "...";
                this.txtbtn.renderControl();
                this.txtbtn.Visible = true;
            }
        }
        void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colIndex && e.RowIndex > -1 && e.RowIndex != this.dgvPackProdSuppl.NewRowIndex)
            {
               // this.dgvPackProdSuppl.CurrentCell.Value = this.txtbtn.Text;
                this.txtbtn.Visible = false;
            }
        }
        //*******************************************************************************//
        //  END OF CUSTOM USER CONTROL PART
        //*******************************************************************************//

        private void PackagesForm_Load(object sender, EventArgs e)
        {
            Constants.packageIsChanged = false;
            if (itIsNewForm == false)
            {
                // if form is opened in EDIT mode fill all exusting informartion

                // Create a DGV table
                FormHandler.createProdSupplTable(dgvPackProdSuppl);

                // Create a list of PackProdSuppl objects to popuplate Data Grid View with
                // existing data
                List<PackProdSupplier> packProdSupList = PackProdSupplierDB.getProdSuppliersForDGV(Convert.ToInt32(txtId.Text));

                // Loop through list generated from data table to populate DataGridView
                string[] splitLine = new string[5];

                foreach (PackProdSupplier line in packProdSupList)
                {
                    // variable to break list line into array
                    splitLine = line.PackProdSupplierToString().Split(',');

                    // Create a list of possiple values to populate a combox
                    List<Supplier> supplierIdPairs =
                        PackProdSupplier.createSupplierIdPairsList(Convert.ToInt32(splitLine[1]));

                    // Find index of right element
                    int indOfRightElement = supplierIdPairs.IndexOf(supplierIdPairs.Where(p =>
                                p.SupplierId == Convert.ToInt32(splitLine[3])).FirstOrDefault());

                    // Store values from DataTable
                    DataGridViewRow dgvRow = new DataGridViewRow();

                    dgvRow.Cells.Add(new DataGridViewTextBoxCell());
                    dgvRow.Cells.Add(new DataGridViewTextBoxCell());
                    dgvRow.Cells.Add(new DataGridViewComboBoxCell());
                    dgvRow.Cells.Add(new DataGridViewTextBoxCell());
                    dgvRow.Cells.Add(new DataGridViewTextBoxCell());

                    dgvRow.Cells[0].Value = splitLine[0];
                    dgvRow.Cells[1].Value = splitLine[1];
                    ((DataGridViewComboBoxCell)dgvRow.Cells[2]).FlatStyle = FlatStyle.Flat;
                    ((DataGridViewComboBoxCell)dgvRow.Cells[2]).DataSource = supplierIdPairs;
                    ((DataGridViewComboBoxCell)dgvRow.Cells[2]).DisplayMember = "SupName";
                    ((DataGridViewComboBoxCell)dgvRow.Cells[2]).ValueMember = "SupplierId";
                    ((DataGridViewComboBoxCell)dgvRow.Cells[2]).Value =
                                supplierIdPairs[indOfRightElement].SupplierId;
                    dgvRow.Cells[3].Value = splitLine[3];
                    dgvRow.Cells[4].Value = splitLine[4];

                    dgvPackProdSuppl.Rows.Add(dgvRow);

                    // add item to prodSuppliersIdForUpDate list
                    prodSuppliersIdForUpDate.Add(Convert.ToInt32(dgvRow.Cells[4].Value));
                }
            }
            else {
                // if it is a new form it is needed to generate new Package ID
                txtId.Text = Convert.ToString((PackageDB.getMaxPackIdValue() + 1));
            }

            //**************************************************************************
            //****** ADD CUSTOM BUTTON CONTROL
            //**************************************************************************

            this.txtbtn = new TextAndButtonControlPackForm();
            this.txtbtn.Visible = false;
            this.dgvPackProdSuppl.Controls.Add(this.txtbtn);

            //Handle the cellbeginEdit event to show the usercontrol in the cell while editing
            this.dgvPackProdSuppl.CellBeginEdit += new DataGridViewCellCancelEventHandler(dgv_CellBeginEdit);

            //Handle the cellEndEdit event to update the cell value
            this.dgvPackProdSuppl.CellEndEdit += new DataGridViewCellEventHandler(dgv_CellEndEdit);
            //**************************************************************************
            //****** END OF CUSTOM BUTTON CONTROL
            //**************************************************************************

            FormHandler.captureChanges(this);

            rtxtHint.SelectionAlignment = HorizontalAlignment.Center;
        }

        // METHOD HANDLES CELL CHANGES IN DATAGRIDVIEW
        private void dgvPackProdSuppl_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Clrear Suppliers combobox on change of SupplierID
            if (e.ColumnIndex == 1)
            {
                //Make a Supplier
                dgvPackProdSuppl.Rows[e.RowIndex].Cells[2].Value = null;

                // Create a list of possiple values to populate a combox
                List<Supplier> supplierIdPairs =
                    PackProdSupplier.createSupplierIdPairsList(Convert.ToInt32(dgvPackProdSuppl.Rows[e.RowIndex].Cells[1].Value));
                ((DataGridViewComboBoxCell)dgvPackProdSuppl.Rows[e.RowIndex].
                    Cells[2]).DataSource = supplierIdPairs;
                ((DataGridViewComboBoxCell)dgvPackProdSuppl.Rows[e.RowIndex].
                    Cells[2]).DisplayMember = "SupName";
                ((DataGridViewComboBoxCell)dgvPackProdSuppl.Rows[e.RowIndex].
                    Cells[2]).ValueMember = "SupplierId";
            }

            // Change SupplierID on change of Supplier
            if (e.ColumnIndex == 2) {
                if (dgvPackProdSuppl.Rows[e.RowIndex].Cells[2].Value != null)
                {
                    dgvPackProdSuppl.Rows[e.RowIndex].Cells[3].Value =
                        dgvPackProdSuppl.Rows[e.RowIndex].Cells[2].Value;
                }
                else {
                    dgvPackProdSuppl.Rows[e.RowIndex].Cells[3].Value = null;
                }
            }

            // Change ProdSupplierID on change of SupplierID
            if (e.ColumnIndex == 3)
            {
                if (dgvPackProdSuppl.Rows[e.RowIndex].Cells[3].Value != null &&
                    dgvPackProdSuppl.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    int prodId = Convert.ToInt32(dgvPackProdSuppl.Rows[e.RowIndex].Cells[1].Value);
                    int supplierId = Convert.ToInt32(dgvPackProdSuppl.Rows[e.RowIndex].Cells[3].Value);
                    dgvPackProdSuppl.Rows[e.RowIndex].Cells[4].Value =
                        DBHandler.getNewProdSupplierId(prodId, supplierId);
                }
                else {
                    dgvPackProdSuppl.Rows[e.RowIndex].Cells[4].Value = null;
                }
            }
        }

        // METHOD ALLOWS TO TYPE IN DGV COMBOBOX TO NARROW DOWN SEARCH
        private void dgvPackProdSuppl_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvPackProdSuppl.CurrentCell.ColumnIndex == 2)
            {
                var comboBox = e.Control as DataGridViewComboBoxEditingControl;
                    comboBox.DropDownStyle = ComboBoxStyle.DropDown;
                    comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }

        // METHOD PREVENT CELL CHANGING ON ENTER PRESS
        private void dgvPackProdSuppl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                int col = dgvPackProdSuppl.CurrentCell.ColumnIndex;
                int row = dgvPackProdSuppl.CurrentCell.RowIndex;

                if (row == dgvPackProdSuppl.RowCount)
                    dgvPackProdSuppl.Rows.Add();

                dgvPackProdSuppl.CurrentCell = dgvPackProdSuppl[col, row];
                e.Handled = true;
            }
        }

        //**************************************************************************
        //*** MENU STRING BUTTONS ABOVE DGV
        //**************************************************************************

        // METHOD CREATES A NEW DGV ROW ON PLUS BUTTON CLICK
        private void tsbAddProdSup_Click(object sender, EventArgs e)
        {
            if (dgvPackProdSuppl.Columns.Count == 0)
            {
                FormHandler.createProdSupplTable(dgvPackProdSuppl);
            }
            dgvPackProdSuppl.Rows.Add("","","","","");
            int newRowIndex = dgvPackProdSuppl.Rows.Count;
            dgvPackProdSuppl.CurrentCell = dgvPackProdSuppl.Rows[newRowIndex-1].Cells[0];
            dgvPackProdSuppl.BeginEdit(true);
        }

        // METHOD EDITS SELECTED DGW ROW ON EDIT BUTTON CLICK
        private void tsbEditProdSup_Click(object sender, EventArgs e)
        {
            dgvPackProdSuppl.CurrentCell = dgvPackProdSuppl.CurrentRow.Cells[0];
            dgvPackProdSuppl.BeginEdit(true);
            this.txtbtn.button1_Click(sender, e);
        }

        // METHOD DELETES SELECTED DGW ROW ON DELETE BUTTON CLICK
        private void tsbDeleteProdSup_Click(object sender, EventArgs e)
        {
            if (dgvPackProdSuppl.Rows.Count != 0) {
                dgvPackProdSuppl.Rows.RemoveAt(dgvPackProdSuppl.CurrentRow.Index);
            }
        }

        //**************************************************************************
        //*** SAVE AND CANCEL BUTTONS
        //**************************************************************************

        // SAVE BUTTON CLICK
        private void btnSave_Click(object sender, EventArgs e)
        {
            // First check if all text boxes and grid view are filled properly
            if (PackFormValidator.checkTextFields(txtName, txtDesc) &&
                PackFormValidator.checkCommission(txtBasePrice, txtAgComm) &&
                PackFormValidator.checkDates(tpStartDate, tpEndDate) &&
                PackFormValidator.dgvIsNotEmpty(dgvPackProdSuppl) &&
                PackFormValidator.dgvIsFilled(dgvPackProdSuppl)) {


                // Set this bool variable to true so app won't try to save data twice
                useSaveButton = true;

                // Create an instance of Package class from the form
                Package pack = new Package();
                pack.PackName = txtName.Text;
                pack.PackStartDate = Convert.ToDateTime(tpStartDate.Text);
                pack.PackEndDate = Convert.ToDateTime(tpEndDate.Text);
                pack.PackDesc = txtDesc.Text;
                pack.PackBasePrice = Convert.ToDecimal(txtBasePrice.Text);
                pack.PackAgncyCommission = Convert.ToDecimal(txtAgComm.Text);
                pack.PkgImage = imgDescription.Text;

                // Create a list of innstances of PackIdProdSupId
                List<PackIdProdSupId> pps = new List<PackIdProdSupId>();
                for (int i = 0; i < dgvPackProdSuppl.Rows.Count; i++)
                {
                    PackIdProdSupId item = new PackIdProdSupId(Convert.ToInt32(txtId.Text),
                        Convert.ToInt32(dgvPackProdSuppl.Rows[i].Cells[4].Value));
                    pps.Add(item);
                }

                // If it is a new form just insert gatherd values into DB
                if (itIsNewForm == true)
                {
                    // Insert data into Package Table
                    PackageDB.insertPackages(pack);

                    // Insert data into Packages_Products_Suppliers
                    PackProdSupplierDB.insertPackages_Products_Suppliers(pps);

                    FormHandler.upDatePackList(Convert.ToInt32(txtId.Text));
                    this.Close();
                }
                else {
                    // Update data in Package Table
                    PackageDB.updatePackages(pack, Convert.ToInt32(txtId.Text));

                    // Update data in Packages_Products_Suppliers Table
                    PackProdSupplierDB.updatePackages_Products_Suppliers(pps, prodSuppliersIdForUpDate);

                    FormHandler.upDatePackList(Convert.ToInt32(txtId.Text));
                    this.Close();
                }
            }
        }

        // CANCEL BUTTON CLICK 
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Constants.packageIsChanged == true)
            {
                // Ask user if he/she wants to save data
                DialogResult dr = MessageBox.Show("Package info has been changed. Do you want sate changes before you close it",
                      "Closing Form", MessageBoxButtons.YesNoCancel);
                useCancelButton = true;

                // Processing user's answer
                switch (dr)
                {
                    case DialogResult.Yes:
                        this.btnSave_Click(null, null);
                        Close();
                        break;
                    case DialogResult.No:
                        Close();
                        break;
                    case DialogResult.Cancel:
                        useCancelButton = false;
                        break;
                }
            }
            else
            {
                Close();
            }
        }
        // UPPER-RIGHT CORNER X BUTTON
        private void PackagesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Constants.packageIsChanged == true && useCancelButton == false && useSaveButton == false)
            {
                // Ask user if he/she wants to save data
                DialogResult dr = MessageBox.Show("Package info has been changed. Do you want sate changes before you close it",
                      "Closing Form", MessageBoxButtons.YesNoCancel);

                // Processing user's answer
                switch (dr)
                {
                    case DialogResult.Yes:
                        this.btnSave_Click(null, null);
                        Close();
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        // Method handles form behavior on IMAGE LOAD BUTTON CLICK
        private void btnManipulImage_Click(object sender, EventArgs e)
        {


            if (packageHasImage == false)
            {
                // Inititialize Dialog
                OpenFileDialog open = new OpenFileDialog();
                open.InitialDirectory = @"C:\Users\803395\Pictures";
                open.Filter = "Image Files (*.jpg)|*.jpg|All files(*.*)|*.*";
                open.FilterIndex = 1;

                // Open dialog 
                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (open.CheckFileExists)
                    {
                        //string newFileName = System.IO.Path.GetFileName(open.FileName);
                        // Create the name of the file
                        newFileName = txtName.Text + txtId.Text + ".jpg";
                        // Save file to a new folder
                        System.IO.File.Copy(open.FileName, Constants.IMAGESPATH + newFileName, true);

                        // Change the label, image and button
                        imgDescription.Text = newFileName;
                        imgDescription.BackColor = Color.White;
                        imgDescription.ForeColor = Color.Gray;
                        imgDescription.BorderStyle = BorderStyle.None;
                        // Button
                        btnManipulImage.Text = "X";
                        // Image
                        imgPackage.Image = Image.FromFile(Constants.IMAGESPATH + newFileName);

                        // Variable
                        packageHasImage = true;
                    }
                }        
            }
            else {
                // label
                imgDescription.Text = "";
                imgDescription.BackColor = Color.White;
                imgDescription.BorderStyle = BorderStyle.FixedSingle;
                // Image
                imgPackage.Image = null;
                // button
                btnManipulImage.Text = "...";

                packageHasImage = false;
            }

        }
    } // end of class
} // end of namespace
