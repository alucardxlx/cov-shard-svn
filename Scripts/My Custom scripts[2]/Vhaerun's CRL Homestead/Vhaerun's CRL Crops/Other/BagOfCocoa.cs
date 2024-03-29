using System;
using Server.Network;

namespace Server.Items
{
	public class BagOfCocoa : Item
	{

		[Constructable]
		public BagOfCocoa() : base( 0x1039 )
		{
			Weight = 5.0;
			Hue = 0x475;
			Name = "Bag of Cocoa";
            Stackable = true;
            //Amount = amount;
		}

		public BagOfCocoa( Serial serial ) : base( serial )
		{
		}


		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}