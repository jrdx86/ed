using System;

namespace Cbingo
{
	public class Bombo
	{
		private List <int> bolas = new List<int>();
		public Bombo ()	{
			for (int bola = 1; bola <= 90; bola++)
							bolas.Add (bola);
		}
		private Random random = new Random();
		public int SacarBola(){
			return 1; //TODO
	}
		public bool QuedanBolas(){
			return true;//todo
		}
	}
}

