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
	public class AG_BathTubEastAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new AG_BathTubEastAddonDeed();
			}
		}

		[ Constructable ]
		public AG_BathTubEastAddon()
		{
			AddComponent( new AddonComponent( 1811 ), 2, 2, 0 );
			AddComponent( new AddonComponent( 1813 ), 2, -1, 0 );
			AddComponent( new AddonComponent( 1803 ), 2, 0, 0 );
			AddComponent( new AddonComponent( 1803 ), -2, -1, 0 );
			AddComponent( new AddonComponent( 1803 ), 2, 1, 0 );
			AddComponent( new AddonComponent( 1805 ), 1, -1, 0 );
			AddComponent( new AddonComponent( 1805 ), 1, 2, 0 );
			AddComponent( new AddonComponent( 1818 ), 1, 3, 0 );
			AddComponent( new AddonComponent( 1801 ), 0, -3, 0 );
			AddComponent( new AddonComponent( 6420 ), 0, -3, 5 );
			AddComponent( new AddonComponent( 6420 ), 0, -3, 7 );
			AddComponent( new AddonComponent( 1819 ), -2, -2, 0 );
			AddComponent( new AddonComponent( 1803 ), -2, 1, 0 );
			AddComponent( new AddonComponent( 4100 ), -2, 1, 2 );
			AddComponent( new AddonComponent( 1803 ), -2, 0, 0 );
			AddComponent( new AddonComponent( 4100 ), -2, 0, 2 );
			AddComponent( new AddonComponent( 13456 ), -1, 2, 1 );
			AddComponent( new AddonComponent( 7630 ), -1, 2, 0 );
			AddComponent( new AddonComponent( 1803 ), -2, 2, 0 );
			AddComponent( new AddonComponent( 1802 ), -1, -2, 0 );
			AddComponent( new AddonComponent( 13456 ), -1, -1, 1 );
			AddComponent( new AddonComponent( 7630 ), -1, -1, 0 );
			AddComponent( new AddonComponent( 13456 ), -1, 0, 1 );
			AddComponent( new AddonComponent( 7630 ), -1, 0, 0 );
			AddComponent( new AddonComponent( 13456 ), -1, 1, 1 );
			AddComponent( new AddonComponent( 7630 ), -1, 1, 0 );
			AddComponent( new AddonComponent( 1820 ), -2, 3, 0 );
			AddComponent( new AddonComponent( 1804 ), -1, 3, 0 );
			AddComponent( new AddonComponent( 1805 ), 1, 0, 0 );
			AddComponent( new AddonComponent( 1805 ), 1, 1, 0 );
			AddComponent( new AddonComponent( 1821 ), 1, -2, 0 );
			AddComponent( new AddonComponent( 1801 ), -1, -3, 0 );
			AddComponent( new AddonComponent( 3622 ), -1, -3, 3 );
			AddComponent( new AddonComponent( 1804 ), 0, 3, 0 );
			AddComponent( new AddonComponent( 13456 ), 0, 2, 1 );
			AddComponent( new AddonComponent( 7630 ), 0, 2, 0 );
			AddComponent( new AddonComponent( 13456 ), 0, 1, 1 );
			AddComponent( new AddonComponent( 7630 ), 0, 1, 0 );
			AddComponent( new AddonComponent( 13456 ), 0, 0, 1 );
			AddComponent( new AddonComponent( 7630 ), 0, 0, 0 );
			AddComponent( new AddonComponent( 13456 ), 0, -1, 1 );
			AddComponent( new AddonComponent( 7630 ), 0, -1, 0 );
			AddComponent( new AddonComponent( 1802 ), 0, -2, 0 );
			AddonComponent ac;
			ac = new AddonComponent( 1803 );
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 1803 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 1803 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 1803 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 1802 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 1802 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 1804 );
			AddComponent( ac, -1, 3, 0 );
			ac = new AddonComponent( 1804 );
			AddComponent( ac, 0, 3, 0 );
			ac = new AddonComponent( 1805 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 1805 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 1805 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 1805 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 1821 );
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 1820 );
			AddComponent( ac, -2, 3, 0 );
			ac = new AddonComponent( 1819 );
			AddComponent( ac, -2, -2, 0 );
			ac = new AddonComponent( 1818 );
			AddComponent( ac, 1, 3, 0 );
			ac = new AddonComponent( 1801 );
			AddComponent( ac, -1, -3, 0 );
			ac = new AddonComponent( 1801 );
			AddComponent( ac, 0, -3, 0 );
			ac = new AddonComponent( 4100 );
			ac.Name = "Hot";
			AddComponent( ac, -2, 1, 2 );
			ac = new AddonComponent( 4100 );
			ac.Name = "Cold";
			AddComponent( ac, -2, 0, 2 );
			ac = new AddonComponent( 6420 );
			ac.Hue = 1264;
			ac.Name = "His";
			AddComponent( ac, 0, -3, 5 );
			ac = new AddonComponent( 6420 );
			ac.Hue = 1166;
			ac.Name = "Hers";
			AddComponent( ac, 0, -3, 7 );
			ac = new AddonComponent( 3622 );
			ac.Name = "Bath Oil";
			AddComponent( ac, -1, -3, 3 );
			ac = new AddonComponent( 13456 );
			AddComponent( ac, -1, -1, 1 );
			ac = new AddonComponent( 13456 );
			AddComponent( ac, -1, 0, 1 );
			ac = new AddonComponent( 13456 );
			AddComponent( ac, -1, 1, 1 );
			ac = new AddonComponent( 13456 );
			AddComponent( ac, -1, 2, 1 );
			ac = new AddonComponent( 13456 );
			AddComponent( ac, 0, -1, 1 );
			ac = new AddonComponent( 13456 );
			AddComponent( ac, 0, 0, 1 );
			ac = new AddonComponent( 13456 );
			AddComponent( ac, 0, 1, 1 );
			ac = new AddonComponent( 13456 );
			AddComponent( ac, 0, 2, 1 );
			ac = new AddonComponent( 7630 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 7630 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 7630 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 7630 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 7630 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 7630 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 7630 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 7630 );
			AddComponent( ac, -1, 2, 0 );

		}

		public AG_BathTubEastAddon( Serial serial ) : base( serial )
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

	public class AG_BathTubEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new AG_BathTubEastAddon();
			}
		}

		[Constructable]
		public AG_BathTubEastAddonDeed()
		{
			Name = "AG_BathTubEast";
		}

		public AG_BathTubEastAddonDeed( Serial serial ) : base( serial )
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