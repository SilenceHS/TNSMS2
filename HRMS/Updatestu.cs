using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HRMS
{
    class Updatestu:AddStudent
    {
        public Updatestu(DataGridView DGrid)
        {
            IDtextBox.Text = DGrid[0, DGrid.CurrentCell.RowIndex].Value.ToString();
            NametextBox.Text = DGrid[1, DGrid.CurrentCell.RowIndex].Value.ToString();
            SexcomboBox.Text = DGrid[2, DGrid.CurrentCell.RowIndex].Value.ToString();
            PositiontextBox.Text = DGrid[3, DGrid.CurrentCell.RowIndex].Value.ToString();
            PhonetextBox.Text = DGrid[4, DGrid.CurrentCell.RowIndex].Value.ToString();
            AddresstextBox.Text = DGrid[5, DGrid.CurrentCell.RowIndex].Value.ToString();
            EmailtextBox.Text = DGrid[6, DGrid.CurrentCell.RowIndex].Value.ToString();
            textBox.Text = DGrid[7, DGrid.CurrentCell.RowIndex].Value.ToString();
        }
    }
}
