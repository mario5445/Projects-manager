using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjectsManager
{
    public class Exporting
    {
        private DataGridView data = null;
        public Exporting(DataGridView data) 
        {
            this.data = data;
        }

        public void ExportToPdf()
        {
            if (data.Rows.Count < 1)
            {
                MessageBox.Show("Žiadne údaje pre export");
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "Export.pdf";
            bool fileError = false;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(sfd.FileName))
                {
                    try
                    {
                        File.Delete(sfd.FileName);
                    }
                    catch (IOException)
                    {
                        fileError = true;
                        MessageBox.Show("Nepodarilo sa zapísať dáta na váš disk");
                        return;
                    }
                }
                if (!fileError)
                {
                    try
                    {
                        PdfPTable pdfPTable = new PdfPTable(data.Columns.Count - 1);
                        pdfPTable.DefaultCell.Padding = 3;
                        pdfPTable.WidthPercentage = 100;
                        pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;


                        string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIAL.TTF");

                        //Create a base font object making sure to specify IDENTITY-H
                        BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                        //Create a specific font object
                        Font f = new Font(bf, 12, Font.NORMAL);

                        //Font FONT = FontFactory.GetFont("ARIAL", 12F);
                        //BaseFont bf = BaseFont.CreateFont(FONT.ToString(), BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                        //Font fon = new Font(bf, 12, Font.NORMAL);
                        foreach (DataGridViewColumn column in data.Columns)
                        {
                            if (column.Index != 0)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, f));
                                pdfPTable.AddCell(cell);
                            }
                        }

                        foreach (DataGridViewRow row in data.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.ColumnIndex != 0)
                                {
                                    PdfPCell cell_p = new PdfPCell(new Phrase(cell.Value.ToString(), f));
                                    pdfPTable.AddCell(cell_p);
                                }
                            }
                        }
                        using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();
                            pdfDoc.Add(pdfPTable);
                            pdfDoc.Close();
                            stream.Close();
                        }
                        MessageBox.Show("Dáta boli úspešne exportované!");
                        return;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error");
                        return;
                    }
                }
            }
        }

        public void ExportToExcel()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = "Export";
                saveFileDialog.DefaultExt = ".xlsx";
                saveFileDialog.Filter = "Excel |*.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                    worksheet = workbook.Sheets[1];
                    worksheet = workbook.ActiveSheet;
                    worksheet.Name = "Projekty export";

                    for (int i = 1; i < data.Columns.Count + 1; i++)
                    {
                        if (i != 1)
                        {
                            worksheet.Cells[1, i] = data.Columns[i - 1].HeaderText;
                        }
                    }
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        for (int j = 0; j < data.Columns.Count; j++)
                        {
                            if (j != 0)
                            {
                                worksheet.Cells[i + 2, j + 1] = data.Rows[i].Cells[j].Value.ToString();
                            }
                            
                        }
                    }
                    workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("Dáta boli úspešne exportované!");
                }                
            }
        }
    }
}
