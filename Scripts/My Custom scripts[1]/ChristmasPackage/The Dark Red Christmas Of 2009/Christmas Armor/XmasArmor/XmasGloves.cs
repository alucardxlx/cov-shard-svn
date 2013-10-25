using System;
using Server.Network;
using Server.Items;
using Server.Targeting;

namespace Server.Items
{
	public class XmasGloves : BoneGloves 
  {
public override int ArtifactRarity{ get{ return 10; } }

		public override int InitMinHits{ get{ return 4; } }
		public override int InitMaxHits{ get{ return 10; } }

		public override int BaseColdResistance{ get{ return 10; } } 
		public override int BaseEnergyResistance{ get{ return 4; } }  
      
      [Constructable]
		public XmasGloves()
		{
          Name = "Xmas Gloves";
          Hue = 64;

          Attributes.Luck = 100; 
	    }

		public XmasGloves( Serial serial ) : base( serial )
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
