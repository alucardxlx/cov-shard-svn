/////////////////////////////////////////////////
//                                             //
// Automatically generated by the              //
// AddonGenerator script by Arya               //
//                                             //
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class AG_BathTubSouthAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new AG_BathTubSouthAddonDeed();
			}
		}

		[ Constructable ]
		public AG_BathTubSouthAddon()
		{
			AddComponent( new AddonComponent( 1804 ), -2, 1, 0 );
			AddComponent( new AddonComponent( 1820 ), -3, 1, 0 );
			AddComponent( new AddonComponent( 13456 ), -2, -1, 1 );
			AddComponent( new AddonComponent( 7633 ), -2, -1, 0 );
			AddComponent( new AddonComponent( 13456 ), -2, 0, 1 );
			AddComponent( new AddonComponent( 7633 ), -2, 0, 0 );
			AddComponent( new AddonComponent( 1801 ), 3, 0, 0 );
			AddComponent( new AddonComponent( 6420 ), 3, 0, 5 );
			AddComponent( new AddonComponent( 6420 ), 3, 0, 7 );
			AddComponent( new AddonComponent( 1818 ), 2, 1, 0 );
			AddComponent( new AddonComponent( 1801 ), 3, -1, 0 );
			AddComponent( new AddonComponent( 3622 ), 3, -1, 5 );
			AddComponent( new AddonComponent( 1805 ), 2, -1, 0 );
			AddComponent( new AddonComponent( 1805 ), 2, 0, 0 );
			AddComponent( new AddonComponent( 1811 ), 1, 2, 0 );
			AddComponent( new AddonComponent( 1804 ), 1, 1, 0 );
			AddComponent( new AddonComponent( 13456 ), 1, 0, 1 );
			AddComponent( new AddonComponent( 7632 ), 1, 0, 0 );
			AddComponent( new AddonComponent( 7632 ), 1, -1, 0 );
			AddComponent( new AddonComponent( 13456 ), 1, -1, 1 );
			AddComponent( new AddonComponent( 1802 ), 1, -2, 0 );
			AddComponent( new AddonComponent( 1821 ), 2, -2, 0 );
			AddComponent( new AddonComponent( 13456 ), 0, 0, 1 );
			AddComponent( new AddonComponent( 7633 ), 0, 0, 0 );
			AddComponent( new AddonComponent( 1804 ), 0, 1, 0 );
			AddComponent( new AddonComponent( 1802 ), 0, 2, 0 );
			AddComponent( new AddonComponent( 13456 ), 0, -1, 1 );
			AddComponent( new AddonComponent( 7633 ), 0, -1, 0 );
			AddComponent( new AddonComponent( 13456 ), -1, -1, 1 );
			AddComponent( new AddonComponent( 7632 ), -1, -1, 0 );
			AddComponent( new AddonComponent( 1802 ), -1, 2, 0 );
			AddComponent( new AddonComponent( 1804 ), -1, 1, 0 );
			AddComponent( new AddonComponent( 13456 ), -1, 0, 1 );
			AddComponent( new AddonComponent( 7632 ), -1, 0, 0 );
			AddComponent( new AddonComponent( 1812 ), -2, 2, 0 );
			AddComponent( new AddonComponent( 1803 ), -3, 0, 0 );
			AddComponent( new AddonComponent( 4100 ), -3, 0, 2 );
			AddComponent( new AddonComponent( 1803 ), -3, -1, 0 );
			AddComponent( new AddonComponent( 4100 ), -3, -1, 2 );
			AddComponent( new AddonComponent( 1819 ), -3, -2, 0 );
			AddComponent( new AddonComponent( 1802 ), -2, -2, 0 );
			AddComponent( new AddonComponent( 1802 ), -1, -2, 0 );
			AddComponent( new AddonComponent( 1802 ), 0, -2, 0 );
			AddonComponent ac;
			ac = new AddonComponent( 1802 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 1802 );
			AddComponent( ac, -2, -2, 0 );
			ac = new AddonComponent( 1802 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 1819 );
			AddComponent( ac, -3, -2, 0 );
			ac = new AddonComponent( 1803 );
			AddComponent( ac, -3, -1, 0 );
			ac = new AddonComponent( 1803 );
			AddComponent( ac, -3, 0, 0 );
			ac = new AddonComponent( 1804 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 1804 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 1804 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 1820 );
			AddComponent( ac, -3, 1, 0 );
			ac = new AddonComponent( 4100 );
			ac.Name = "Hot";
			AddComponent( ac, -3, 0, 2 );
			ac = new AddonComponent( 4100 );
			ac.Name = "Cold";
			AddComponent( ac, -3, -1, 2 );
			ac = new AddonComponent( 13456 );
			AddComponent( ac, -2, -1, 1 );
			ac = new AddonComponent( 13456 );
			AddComponent( ac, -2, 0, 1 );
			ac = new AddonComponent( 13456 );
			AddComponent( ac, -1, -1, 1 );
			ac = new AddonComponent( 13456 );
			AddComponent( ac, -1, 0, 1 );
			ac = new AddonComponent( 13456 );
			AddComponent( ac, 0, -1, 1 );
			ac = new AddonComponent( 13456 );
			AddComponent( ac, 0, 0, 1 );
			ac = new AddonComponent( 7632 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 7632 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 7633 );
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 7633 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 7633 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 7633 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 1802 );
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 1821 );
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 7632 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 1804 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 1805 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 1805 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 1818 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 1801 );
			AddComponent( ac, 3, -1, 0 );
			ac = new AddonComponent( 1801 );
			AddComponent( ac, 3, 0, 0 );
			ac = new AddonComponent( 13456 );
			AddComponent( ac, 1, -1, 1 );
			ac = new AddonComponent( 13456 );
			AddComponent( ac, 1, 0, 1 );
			ac = new AddonComponent( 6420 );
			ac.Hue = 1264;
			ac.Name = "His";
			AddComponent( ac, 3, 0, 5 );
			ac = new AddonComponent( 6420 );
			ac.Hue = 1166;
			ac.Name = "Hers";
			AddComponent( ac, 3, 0, 7 );
			ac = new AddonComponent( 3622 );
			ac.Name = "Bath Oil";
			AddComponent( ac, 3, -1, 5 );
			ac = new AddonComponent( 7632 );
			AddComponent( ac, 1, 0, 0 );

		}

		public AG_BathTubSouthAddon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class AG_BathTubSouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new AG_BathTubSouthAddon();
			}
		}

		[Constructable]
		public AG_BathTubSouthAddonDeed()
		{
			Name = "AG_BathTubSouth";
		}

		public AG_BathTubSouthAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}