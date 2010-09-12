using System.Collections;	
using System.Windows.Forms;

namespace GI.Framework.ListView
{
	public class ListViewColumnSorter : IComparer
	{
		
		private int ColumnToSort;
		
		private SortOrder OrderOfSort;
		
		private CaseInsensitiveComparer ObjectCompare;

		
		public enum TipoComparacion{STRING, DATETIME, INT};
		private TipoComparacion ElTipo;

		public void SetTipoComparacion(TipoComparacion Tipo)
		{
			ElTipo = Tipo;
		}

		
		public ListViewColumnSorter()
		{
			
			ColumnToSort = 0;

			
			OrderOfSort = SortOrder.None;

			
			ObjectCompare = new CaseInsensitiveComparer();

			ElTipo = TipoComparacion.STRING;
		}

		
		public virtual int Compare(object x, object y)
		{
			switch(ElTipo)
			{
				case TipoComparacion.DATETIME:
					return CompareDateTime(x, y);
				case TipoComparacion.STRING:
					return CompareString(x, y);
				case TipoComparacion.INT:
					return CompareInt(x, y);
				default:
					return CompareString(x, y);
			}
		}

		private int CompareString(object x, object y)
		{
			int compareResult;
			ListViewItem listviewX, listviewY;

			
			listviewX = (ListViewItem)x;
			listviewY = (ListViewItem)y;

			
			compareResult = ObjectCompare.Compare(listviewX.SubItems[ColumnToSort].Text,listviewY.SubItems[ColumnToSort].Text);
			
			
			if (OrderOfSort == SortOrder.Ascending)
			{
				
				return compareResult;
			}
			else if (OrderOfSort == SortOrder.Descending)
			{
				
				return (-compareResult);
			}
			else
			{
				
				return 0;
			}
		}

		private int CompareDateTime(object x, object y)
		{
			int compareResult;
			ListViewItem listviewX, listviewY;

			
			listviewX = (ListViewItem)x;
			listviewY = (ListViewItem)y;

		
			compareResult = System.DateTime.Compare(System.Convert.ToDateTime(listviewX.SubItems[ColumnToSort].Text), System.Convert.ToDateTime(listviewY.SubItems[ColumnToSort].Text));
			
			
			if (OrderOfSort == SortOrder.Ascending)
			{
				
				return compareResult;
			}
			else if (OrderOfSort == SortOrder.Descending)
			{
				
				return (-compareResult);
			}
			else
			{
				
				return 0;
			}
		}

		private int CompareInt(object x, object y)
		{
			int compareResult;
			ListViewItem listviewX, listviewY;

			
			listviewX = (ListViewItem)x;
			listviewY = (ListViewItem)y;

			
			try
			{
				compareResult = (System.Convert.ToInt32(listviewX.SubItems[ColumnToSort].Text)) - (System.Convert.ToInt32(listviewY.SubItems[ColumnToSort].Text));
			}
			catch
			{
				compareResult = ObjectCompare.Compare(listviewX.SubItems[ColumnToSort].Text,listviewY.SubItems[ColumnToSort].Text);
			}
			
			if (OrderOfSort == SortOrder.Ascending)
			{
				
				return compareResult;
			}
			else if (OrderOfSort == SortOrder.Descending)
			{
				
				return (-compareResult);
			}
			else
			{
				
				return 0;
			}
		}
    
		
		public int SortColumn
		{
			set
			{
				ColumnToSort = value;
			}
			get
			{
				return ColumnToSort;
			}
		}

		
		public SortOrder Order
		{
			set
			{
				OrderOfSort = value;
			}
			get
			{
				return OrderOfSort;
			}
		}
    
	}
}
