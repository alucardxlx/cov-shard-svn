using System;
using Server;
using Server.Engines.Craft;


namespace Server.Items
{
	public class RunicG : RunicHammer
	{

		[Constructable]
		public RunicG() : this( 50 )
		{
		}		

		[Constructable]
		public RunicG( int uses ) : base( CraftResource.Gold )
		{
			Weight = 1.0;
			UsesRemaining = uses;
		}
		public RunicG( Serial serial ) : base( serial )
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