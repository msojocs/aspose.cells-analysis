// See https://aka.ms/new-console-template for more information
using Aspose.Cells;

Console.WriteLine("Hello, World!");

var license = new License();
var file = new FileStream("../../../../../license.lic", FileMode.Open);

 license.SetLicense(file);
var excel = new Workbook();
var sheet = excel.Worksheets.Add("test");
sheet.Cells["A1"].Value = "hi";

excel.Save("./test.xlsx", SaveFormat.Xlsx);