using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Victor
 * winningsClass
 * */

namespace SlotMachineExample.Classes
{
    class winningsTicket
    {
        private string ticketFilePath;

        private System.IO.StreamWriter ticketFileSW; // ref variable of type SW

        // Constructor with file path input
        // Create instance of stream writer class (type) and store reference
        public winningsTicket(string filePath)
        {

            ticketFilePath = filePath;
            try
            {
                ticketFileSW = new System.IO.StreamWriter(ticketFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open file " + ticketFilePath + " Terminate Program.",
                            "Output File Connection Error.",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } // end Try
        }//end of updatedFileClass

        //writeRecord onto textfile
        public void writeRecord(string currentRecord)
        {

            ticketFileSW.WriteLine(currentRecord);

        }//end of writeRecord

        // Close the input file
        public void closeFile()
        {
            ticketFileSW.Close();
        } // end Sub

        // Rewind the output file
        public void rewindFile()
        {

            ticketFileSW.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
        } // end rewindFile

    }//end of class
}//end of namespace
