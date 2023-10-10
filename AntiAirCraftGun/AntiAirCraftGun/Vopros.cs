using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiAircraftGun
{
	public class Vopros
	{
		private int _id;

		public int change_id { set {  _id = value; } }

		public void Change(int id)
		{
			change_id = id;
		}
	}
}
