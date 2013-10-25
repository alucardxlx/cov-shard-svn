// Original Author Unknown
// Updated to be halloween 2007 by GreyWolf

using System;
using Server;
using Server.Items;

namespace Server.Items
{  
	public class HalloweenTunic2011 : Tunic
	{
           	[Constructable]
           	public HalloweenTunic2011()
           	{
           		Name = "a Spectral Doublet";
			Hue = 0x4001;
			LootType = LootType.Blessed;
           	}

           	[Constructable]
           	public HalloweenTunic2011(int amount)
           	{
           	}

           	public HalloweenTunic2011(Serial serial) : base( serial )
           	{
           	}

		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2011" );
		}

          	public override void Serialize(GenericWriter writer)
          	{
           		base.Serialize(writer);

           		writer.Write((int)0); // version 
     		}

           	public override void Deserialize(GenericReader reader)
      	{
           		base.Deserialize(reader);

          		int version = reader.ReadInt();
           	}
	}
}
