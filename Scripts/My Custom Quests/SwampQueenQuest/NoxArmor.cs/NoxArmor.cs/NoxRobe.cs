/////////////////////////////////////
//**Generated by Ryans Scripts**//
/////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
    public class NoxRobe : Kamishimo, ITokunoDyable
	{
	 	public override int ArtifactRarity{ get{ return 10; } }

	 	[Constructable]
	 	public NoxRobe()
	 	{
	 	 	Name = "Robe of the Swamp Queen";
	 	 	Hue = 1272;
			Attributes.BonusInt = 10;
			Attributes.BonusMana = 5;
			Attributes.BonusStam = 10;
			Attributes.CastRecovery = 3;
			Attributes.CastSpeed = 1;
			Attributes.DefendChance = 15;
			Attributes.Luck = 150;
			Attributes.NightSight = 1;
			Attributes.ReflectPhysical = 15;
			Attributes.RegenHits = 3;
			Attributes.RegenMana = 2;

	 	}

	 	public NoxRobe(Serial serial) : base( serial )
	 	{
	 	}
	 	public override void Serialize( GenericWriter writer )
	 	{
	 	 	base.Serialize( writer );

	 	 	writer.Write( (int) 0 );
	 	}
	 	public override void Deserialize(GenericReader reader)
	 	{
	 	 	base.Deserialize( reader );

	 	 	int version = reader.ReadInt();
	 	}
	}
}
