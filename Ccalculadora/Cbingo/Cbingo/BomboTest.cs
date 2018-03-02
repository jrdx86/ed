using NUnit.Framework;
using System;

namespace Cbingo
{
	[TestFixture ()]
	public class BomboTest
	{
		[Test ()]
		public void SacarBola ()
		{
			List<int> bolas = new List<int> ();
			Bombo bombo = new Bombo ();

			for (int contador = 1; contador <= 90; contador++) {
				int bola = bombo.SacarBola ();
				Assert.IsTrue (bola >= 1 && bola <= 90, "Debe estar entre 1 y 90");
				Assert.IsFalse (bolas.Contains (bola), "bola repetida: " + bola);
			
		}
	}
		[Test]
		public void QuedanBolas (){
			Bombo bombo = new Bombo ();
			Assert.IsTrue (bombo.QuedanBolas (), "Inicialmente deben quedar bolas");
			for (int contador = 1; contador <=90; contador++){
				Assert.IsTrue (bombo.QuedanBolas (), "Deben quedar bolas");
				bombo.SacarBola ();

		}
			Assert.IsFalse (bombo.QuedanBolas (), "No debe quedar ninguna bola");
