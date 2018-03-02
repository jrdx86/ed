using System;

namespace Cbingo
{
	public class Panel
	{
		private List<Button> buttons = new List <Button>();
		public Panel (Container parent){
		}
		public void MarcarNumero (int numero){
			Table table = new Table (9, 10, true);
				for (int index = 0; index < 90; index++) {
						Button button = new Button ();
						button.Label = (index + 1).ToString ();
						button.Visible = true;
						uint row = (uint)(index / 10);
						uint column = (uint)(index % 10);
						table.Attach (button, column, column + 1, row, row + 1);
						buttons.Add (button);
	}
}

