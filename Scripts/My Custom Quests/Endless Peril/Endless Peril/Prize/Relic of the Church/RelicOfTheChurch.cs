using System;
using Server.Items;
using Server.Mobiles;
using Server.Network;

namespace Server.Items
{
   public class RelicOfTheChurch : BaseShield
   {
		public override int BasePhysicalResistance{ get{ return 20; } }
		public override int BaseFireResistance{ get{ return 15; } }
		public override int BaseColdResistance{ get{ return 15; } }
		public override int BasePoisonResistance{ get{ return 15; } }
		public override int BaseEnergyResistance{ get{ return 15; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		public override int AosStrReq{ get{ return 50; } }

		public override int ArmorBase{ get{ return 30; } }

      [Constructable]
      public RelicOfTheChurch() : base( 0x1B76 )
      {

	ArmorAttributes.SelfRepair = 8;
	Attributes.ReflectPhysical = 15;
	Attributes.LowerManaCost = 20;
	Attributes.SpellChanneling = 1;
	Attributes.CastRecovery = 2;
	Attributes.DefendChance = 15;
	Attributes.CastSpeed = 2;
	Attributes.SpellDamage = 10;

         	Name = "Relic Of The Church";
            Hue = 1153;
         	LootType=LootType.Blessed;
      }

      public override void OnDoubleClick( Mobile from )
      {
		if( from.InRange( this.GetWorldLocation(), 1 ) ) 
		        {
				if ( from.Criminal )
				{
					from.SendMessage( "Thou art a criminal and the Church does not approve." );
				}

                if (from.Mounted)
                {
                    from.SendMessage("You must dismount before using this item.");
                }

                else
                {

                    if (from.BodyValue == 400 || from.BodyValue == 401 || from.BodyValue == 604 || from.Body == 605)
                    {
                        from.SendMessage("The power of the Church Compels you!");
                        from.BodyMod = 123;
                        Effects.SendLocationParticles(EffectItem.Create(from.Location, from.Map, EffectItem.DefaultDuration), 0, 0, 0, 0, 0, 5060, 0);
                        Effects.PlaySound(from.Location, from.Map, 0x243);

                        Effects.SendMovingParticles(new Entity(Serial.Zero, new Point3D(from.X - 6, from.Y - 6, from.Z + 15), from.Map), from, 0x36D4, 7, 0, false, true, 0x497, 0, 9502, 1, 0, (EffectLayer)255, 0x100);
                        Effects.SendMovingParticles(new Entity(Serial.Zero, new Point3D(from.X - 4, from.Y - 6, from.Z + 15), from.Map), from, 0x36D4, 7, 0, false, true, 0x497, 0, 9502, 1, 0, (EffectLayer)255, 0x100);
                        Effects.SendMovingParticles(new Entity(Serial.Zero, new Point3D(from.X - 6, from.Y - 4, from.Z + 15), from.Map), from, 0x36D4, 7, 0, false, true, 0x497, 0, 9502, 1, 0, (EffectLayer)255, 0x100);

                        Effects.SendTargetParticles(from, 0x375A, 35, 90, 0x00, 0x00, 9502, (EffectLayer)255, 0x100);
                        from.Str += 25;
                        from.Int += 25;
                        from.Dex += 25;
                    }
                    else if (from.BodyMod == 123)
                    {
                        if (from.BodyValue == 401)
                        {
                            from.Str -= 25;
                            from.Int -= 25;
                            from.Dex -= 25;
                            from.BodyMod = 0;
                        }
                        else
                        {

                            from.Str -= 25;
                            from.Int -= 25;
                            from.Dex -= 25;
                            from.BodyMod = 0;
                        }
                    }
                }

		        } 
		        else 
		        { 
		            from.SendLocalizedMessage( 500446 ); // That is too far away. 
		        }
      }

      public RelicOfTheChurch( Serial serial ) : base( serial )
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
