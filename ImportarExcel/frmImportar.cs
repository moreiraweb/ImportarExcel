using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportarExcel
{
  public partial class frmImportar : Form
  {
    public frmImportar()
    {
      InitializeComponent();
    }


    private void LerBySql()
    {
      OleDbConnection conexao = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\teste\LerExcel\01.xls; Extended Properties ='Excel 12.0 Xml; HDR = YES';");

      OleDbDataAdapter adapter = new OleDbDataAdapter("select [EFETIVO DE PESSOAL - MENSAL], f6,f12, f18, trim(f24) from [Efetivo$] where f24<>'' ", conexao);
      DataSet ds = new DataSet();


      try
      {
        conexao.Open();

        adapter.Fill(ds);

        //dgvDados.DataSource = ds.Tables[0];

        /////Para preencher o objto e migrar para o banco
        //foreach (DataRow linha in ds.Tables[0].Rows)
        //{
        //  var linha1 = linha;
        //}

      }
      catch (Exception ex)
      {
        Console.WriteLine("Erro ao acessar os dados: " + ex.Message);
      }
      finally
      {
        conexao.Close();

      }

    }


    private void Ler()
    {
      Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
      excelApp.Visible = false;

      string myPath = @"C:\\teste\\LerExcel\\01.xls";
      Microsoft.Office.Interop.Excel.Workbook wbExcel = excelApp.Workbooks.Open(myPath);
      Microsoft.Office.Interop.Excel.Worksheet wsPlanilha = (Microsoft.Office.Interop.Excel.Worksheet)wbExcel.Worksheets.get_Item(2);
      //int rowIndex = Convert.ToInt32(textBox2.Text);
      //int colIndex = Convert.ToInt32(textBox1.Text);

      string celula = "a" + "b";
      //Para pegar o valor interno sem formatação
      var valor = wsPlanilha.get_Range(celula, celula).Value2;

      //Para pegar o texto exatamente como é mostrado na célula
      var texto = wsPlanilha.get_Range(celula, celula).Text;

      excelApp.Workbooks.Close();
      excelApp.Quit();

      //wbExcel.Close();


      //Mata os objetos COM da memória
      System.Runtime.InteropServices.Marshal.ReleaseComObject(wbExcel);
      System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

    }

    private string getColuna(int iLin, int iCol)
    {
      String[] letras = new String[] { "", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

      if (iCol >= 703)
      {
        int iCol1 = 0;
        int iCol2 = 0;
        int iCol3 = 0;

        iCol2 = iCol / 26;
        if (iCol % 26 == 0)
        {
          iCol2 -= 1;
          iCol3 = 26;
        }
        else
        {
          iCol3 = iCol % 26;
        }

        iCol1 = iCol2 / 26;
        iCol2 = iCol2 % 26;

        return letras[iCol1] + letras[iCol2] + letras[iCol3] + iLin.ToString();
      }
      else
      {
        int iCol1 = 0;
        int iCol2 = 0;

        iCol1 = iCol / 26;
        if (iCol % 26 == 0)
        {
          iCol1 -= 1;
          iCol2 = 26;
        }
        else
        {
          iCol2 = iCol % 26;
        }

        return letras[iCol1] + letras[iCol2] + iLin.ToString();
      }
    }


  }
}
