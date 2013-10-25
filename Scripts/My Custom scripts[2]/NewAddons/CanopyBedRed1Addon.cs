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
	public class CanopyBedRed1Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CanopyBedRed1AddonDeed();
			}
		}

		[ Constructable ]
		public CanopyBedRed1Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 10809 );
			ac.Name = "Canopy";
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 10809 );
			ac.Name = "Canopy";
			AddComponent( ac, -2, -2, 0 );
			ac = new AddonComponent( 9375 );
			ac.Name = "Canopy";
			AddComponent( ac, -2, -1, 17 );
			ac = new AddonComponent( 9375 );
			ac.Name = "Canopy";
			AddComponent( ac, -2, 0, 17 );
			ac = new AddonComponent( 9375 );
			ac.Name = "Canopy";
			AddComponent( ac, -2, 1, 17 );
			ac = new AddonComponent( 9375 );
			ac.Name = "Canopy";
			AddComponent( ac, -2, 2, 17 );
			ac = new AddonComponent( 9376 );
			ac.Name = "Canopy";
			AddComponent( ac, -1, 2, 17 );
			ac = new AddonComponent( 9376 );
			ac.Name = "Canopy";
			AddComponent( ac, -1, -2, 17 );
			ac = new AddonComponent( 10011 );
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 10011 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 10011 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 2682 );
			ac.Hue = 37;
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 2683 );
			ac.Hue = 37;
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 7807 );
			ac.Hue = 1150;
			ac.Name = "nightstand";
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 2842 );
			ac.Light = LightType.Circle225;
			ac.Name = "lamp";
			AddComponent( ac, -1, -1, 8 );
			ac = new AddonComponent( 2330 );
			ac.Hue = 1150;
			ac.Name = "lamp shade";
			AddComponent( ac, -1, -1, 10 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 2766 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 2768 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 5645 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 5645 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 5646 );
			AddComponent( ac, -1, 3, 0 );
			ac = new AddonComponent( 5646 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 5015 );
			ac.Hue = 1153;
			AddComponent( ac, -1, 1, 6 );
			ac = new AddonComponent( 10809 );
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 10809 );
			ac.Name = "Canopy";
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 9375 );
			ac.Name = "Canopy";
			AddComponent( ac, 2, -1, 17 );
			ac = new AddonComponent( 9375 );
			ac.Name = "Canopy";
			AddComponent( ac, 2, 0, 17 );
			ac = new AddonComponent( 9375 );
			ac.Name = "Canopy";
			AddComponent( ac, 2, 1, 17 );
			ac = new AddonComponent( 9375 );
			ac.Name = "Canopy";
			AddComponent( ac, 2, 2, 17 );
			ac = new AddonComponent( 9376 );
			ac.Name = "Canopy";
			AddComponent( ac, 0, 2, 17 );
			ac = new AddonComponent( 9376 );
			ac.Name = "Canopy";
			AddComponent( ac, 1, 2, 17 );
			ac = new AddonComponent( 9376 );
			ac.Name = "Canopy";
			AddComponent( ac, 2, 2, 17 );
			ac = new AddonComponent( 9376 );
			ac.Name = "Canopy";
			AddComponent( ac, 0, -2, 17 );
			ac = new AddonComponent( 9376 );
			ac.Name = "Canopy";
			AddComponent( ac, 1, -2, 17 );
			ac = new AddonComponent( 9376 );
			ac.Name = "Canopy";
			AddComponent( ac, 2, -2, 17 );
			ac = new AddonComponent( 2686 );
			ac.Hue = 37;
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 2681 );
			ac.Hue = 37;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 2766 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 2766 );
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 2767 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 2767 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 2767 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 2768 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 2768 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 2764 );
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 2761 );
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 5645 );
			AddComponent( ac, 3, 2, 0 );
			ac = new AddonComponent( 5645 );
			AddComponent( ac, 3, -1, 0 );
			ac = new AddonComponent( 5646 );
			AddComponent( ac, 2, 3, 0 );
			ac = new AddonComponent( 5646 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 5015 );
			ac.Hue = 1153;
			AddComponent( ac, 0, 1, 16 );

		}

		public CanopyBedRed1Addon( Serial serial ) : base( serial )
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

	public class CanopyBedRed1AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CanopyBedRed1Addon();
			}
		}

		[Constructable]
		public CanopyBedRed1AddonDeed()
		{
			Name = "CanopyBedRed1";
		}

		public CanopyBedRed1AddonDeed( Serial serial ) : base( serial )
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