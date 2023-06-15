using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aspose.Cells;

namespace ArgemAddress.Models
{
    static public class TakeExcel
    {
        static public void ReadExcel(Stream stream)
        {
            // Excel dosyasını yükle
            Workbook wb = new Workbook(stream);

            // Dizini kullanarak çalışma sayfasını alın
            Worksheet worksheet = wb.Worksheets[0];

            // Çalışma sayfası adını yazdır
            Console.WriteLine("Worksheet: " + worksheet.Name);

            // Satır ve sütun sayısını al
            int rows = worksheet.Cells.MaxDataRow;
            int cols = worksheet.Cells.MaxDataColumn;

            // Satırlarda döngü
            for (int i = 0; i < rows; i++)
            {
                // Seçilen satırdaki her sütunda döngü yapın
                for (int j = 0; j < cols; j++)
                {
                    // Pring hücre değeri
                    Console.Write(worksheet.Cells[i, j].Value + " | ");
                }
                // Yazdırma satırı sonu
                Console.WriteLine(" ");
            }

        }

    }
}