using System; 
using Server;
using Server.Items;
using Server.Mobiles;

namespace Server.Mobiles 
{ 
	[CorpseName( " a corpse" )] 
	public class FreddyKruger : BaseCreature 
	{ 
		[Constructable] 
		public FreddyKruger() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 ) 
		{ 
			Name = "Freddy Kruger";
			Body = 185;
                        Hue = 2949;

                     

			SetStr( 481, 705 );
			SetDex( 291, 315 );
			SetInt( 226, 350 );

			SetHits(12000, 14000 );

			SetDamage( 25, 40 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 35, 40 );
			SetResistance( ResistanceType.Fire, 30, 40 );
			SetResistance( ResistanceType.Cold, 30, 40 );
			SetResistance( ResistanceType.Poison, 30, 40 );
			SetResistance( ResistanceType.Energy, 30, 40 );

			SetSkill( SkillName.EvalInt, 80.2, 100.0 );
			SetSkill( SkillName.Magery, 95.1, 100.0 );
			SetSkill( SkillName.Meditation, 27.5, 50.0 );
			SetSkill( SkillName.MagicResist, 77.5, 100.0 );
			SetSkill( SkillName.Tactics, 65.0, 87.5 );
			SetSkill( SkillName.Wrestling, 20.3, 80.0 );

			Fame = 0;
			Karma = -10500;

			VirtualArmor = 90;
                
			LeatherGloves gloves = new LeatherGloves();
			gloves.Hue = 1175;
                        gloves.Movable = false;
			AddItem( gloves );

			LongPants legs = new LongPants();
			legs.Hue = 1175;
                        legs.Movable = false;
			AddItem( legs );

			FingersOfFreddy weapon = new FingersOfFreddy();
			weapon.Movable = false;
			AddItem( weapon );

			Boots boots = new Boots();
			boots.Hue = 1175;
            boots.Movable = false;
			AddItem( boots );

			

		}

		public override bool CanRummageCorpses{ get{ return true; } }
                public override bool BardImmune{ get{ return true; } }
		public override bool AutoDispel{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Lethal; } }
		public override bool AlwaysMurderer{ get{ return true; } }

		public override void GenerateLoot()
		{
			AddLoot( LootPack.UltraRich );
			AddLoot( LootPack.Average );
                      { 
                       switch ( Utility.Random( 10 ) )
			{
			case 0:	PackItem( new FingersOfFreddy() ); break;
            case 1: PackItem(new PumpkinSludge()); break;
		}
 }              }

		public FreddyKruger( Serial serial ) : base( serial ) 
		{ 
		} 

		public override void Serialize( GenericWriter writer ) 
		{ 
			base.Serialize( writer ); 
			writer.Write( (int) 0 ); 
		} 

		public override void Deserialize( GenericReader reader ) 
		{ 
			base.Deserialize( reader ); 
			int version = reader.ReadInt(); 
		} 
	} 
}
