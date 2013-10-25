using System;
using System.Collections;
using Server;
using Server.Items;
using System.Collections.Generic;

namespace Server.Engines.BulkOrders
{
	[TypeAlias( "Scripts.Engines.BulkOrders.SmallBOD" )]
	public abstract class SmallBOD : Item
	{
		private int m_AmountCur, m_AmountMax;
		private Type m_Type;
		private int m_Number;
		private int m_Graphic;
		private bool m_RequireExceptional;
		private BulkMaterialType m_Material;

		[CommandProperty( AccessLevel.GameMaster )]
		public int AmountCur{ get{ return m_AmountCur; } set{ m_AmountCur = value; InvalidateProperties(); } }

		[CommandProperty( AccessLevel.GameMaster )]
		public int AmountMax{ get{ return m_AmountMax; } set{ m_AmountMax = value; InvalidateProperties(); } }

		[CommandProperty( AccessLevel.GameMaster )]
		public Type Type{ get{ return m_Type; } set{ m_Type = value; } }

		[CommandProperty( AccessLevel.GameMaster )]
		public int Number{ get{ return m_Number; } set{ m_Number = value; InvalidateProperties(); } }

		[CommandProperty( AccessLevel.GameMaster )]
		public int Graphic{ get{ return m_Graphic; } set{ m_Graphic = value; } }

		[CommandProperty( AccessLevel.GameMaster )]
		public bool RequireExceptional{ get{ return m_RequireExceptional; } set{ m_RequireExceptional = value; InvalidateProperties(); } }

		[CommandProperty( AccessLevel.GameMaster )]
		public BulkMaterialType Material{ get{ return m_Material; } set{ m_Material = value; InvalidateProperties(); } }

		[CommandProperty( AccessLevel.GameMaster )]
		public bool Complete{ get{ return ( m_AmountCur == m_AmountMax ); } }

		public override int LabelNumber{ get{ return 1045151; } } // a bulk order deed

		[Constructable]
		public SmallBOD( int hue, int amountMax, Type type, int number, int graphic, bool requireExeptional, BulkMaterialType material ) : base( Core.AOS ? 0x2258 : 0x14EF )
		{
			Weight = 1.0;
			Hue = hue; // Blacksmith: 0x44E; Tailoring: 0x483
			LootType = LootType.Blessed;

			m_AmountMax = amountMax;
			m_Type = type;
			m_Number = number;
			m_Graphic = graphic;
			m_RequireExceptional = requireExeptional;
			m_Material = material;
		}

		public SmallBOD() : base( Core.AOS ? 0x2258 : 0x14EF )
		{
			Weight = 1.0;
			LootType = LootType.Blessed;
		}

		public static BulkMaterialType GetRandomMaterial( BulkMaterialType start, double[] chances )
		{
			double random = Utility.RandomDouble();

			for ( int i = 0; i < chances.Length; ++i )
			{
				if ( random < chances[i] )
					return ( i == 0 ? BulkMaterialType.None : start + (i - 1) );

				random -= chances[i];
			}

			return BulkMaterialType.None;
		}

		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( 1060654 ); // small bulk order

			if ( m_RequireExceptional )
				list.Add( 1045141 ); // All items must be exceptional.

			switch ((int)( m_Material ))
			{
				case 1: list.Add("All items must be crafted with dull copper ingots"); break;
				case 2: list.Add("All items must be crafted with shadow iron ingots"); break;
				case 3: list.Add("All items must be crafted with copper ingots"); break;
				case 4: list.Add("All items must be crafted with bronze ingots"); break;
				case 5: list.Add("All items must be crafted with gold ingots"); break;
				case 6: list.Add("All items must be crafted with agapite ingots"); break;
				case 7: list.Add("All items must be crafted with verite ingots"); break;
				case 8: list.Add("All items must be crafted with valorite ingots"); break;
				case 9: list.Add("All items must be crafted with silver ingots"); break;
				//case 10: list.Add("All items must be crafted with platinum ingots"); break;
				//case 11: list.Add("All items must be crafted with mythril ingots"); break;
				//case 12: list.Add("All items must be crafted with obsidian ingots"); break;
				case 10: list.Add("All items must be crafted with jade ingots"); break;
				case 11: list.Add("All items must be crafted with moonstone ingots"); break;
				case 12: list.Add("All items must be crafted with sunstone ingots"); break;
				//case 16: list.Add("All items must be crafted with bloodstone ingots"); break;
				case 13: list.Add("All items must be crafted with spined leather"); break;
				case 14: list.Add("All items must be crafted with horned leather"); break;
				case 15: list.Add("All items must be crafted with barbed leather"); break;
				case 16: list.Add("All items must be crafted with dragon leather"); break;
				case 17: list.Add("All items must be crafted with daemon leather"); break;	
				case 18: list.Add("All items must be crafted with pine wood"); break;
				case 19: list.Add("All items must be crafted with ash wood"); break;
				case 20: list.Add("All items must be crafted with Mahogany wood"); break;
				case 21: list.Add("All items must be crafted with yew wood"); break;
				case 22: list.Add("All items must be crafted with oak wood"); break;			
			}

			list.Add( 1060656, m_AmountMax.ToString() ); // amount to make: ~1_val~
			list.Add( 1060658, "#{0}\t{1}", m_Number, m_AmountCur ); // ~1_val~: ~2_val~
		}

		public override void OnDoubleClick( Mobile from )
		{
			if ( IsChildOf( from.Backpack ) )
				from.SendGump( new SmallBODGump( from, this ) );
			else
				from.SendLocalizedMessage( 1045156 ); // You must have the deed in your backpack to use it.
		}

		public void BeginCombine( Mobile from )
		{
			if ( m_AmountCur < m_AmountMax )
				from.Target = new SmallBODTarget( this );
			else
				from.SendLocalizedMessage( 1045166 ); // The maximum amount of requested items have already been combined to this deed.
		}

		public abstract List<Item> ComputeRewards( bool full );
		public abstract int ComputeGold();
		public abstract int ComputeFame();

		public virtual void GetRewards( out Item reward, out int gold, out int fame )
		{
			reward = null;
			gold = ComputeGold();
			fame = ComputeFame();

			List<Item> rewards = ComputeRewards( false );

			if ( rewards.Count > 0 )
			{
				reward = rewards[Utility.Random( rewards.Count )];

				for ( int i = 0; i < rewards.Count; ++i )
				{
					if ( rewards[i] != reward )
						rewards[i].Delete();
				}
			}
		}

		public static BulkMaterialType GetMaterial( CraftResource resource )
		{
			switch ( resource )
			{
				case CraftResource.DullCopper:		return BulkMaterialType.DullCopper;
				case CraftResource.ShadowIron:		return BulkMaterialType.ShadowIron;
				case CraftResource.Copper:		    return BulkMaterialType.Copper;
				case CraftResource.Bronze:		    return BulkMaterialType.Bronze;
				case CraftResource.Gold:		    return BulkMaterialType.Gold;
				case CraftResource.Agapite:		    return BulkMaterialType.Agapite;
				case CraftResource.Verite:		    return BulkMaterialType.Verite;
				case CraftResource.Valorite:		return BulkMaterialType.Valorite;
				case CraftResource.Silver:		    return BulkMaterialType.Silver;
				//case CraftResource.Platinum:		return BulkMaterialType.Platinum;
				//case CraftResource.Mythril:		return BulkMaterialType.Mythril;
				//case CraftResource.Obsidian:		return BulkMaterialType.Obsidian;
				case CraftResource.Jade:		    return BulkMaterialType.Jade;
				case CraftResource.Moonstone:		return BulkMaterialType.Moonstone;
				case CraftResource.Sunstone:		return BulkMaterialType.Sunstone;
				//case CraftResource.Bloodstone:		return BulkMaterialType.Bloodstone;
				case CraftResource.SpinedLeather:	return BulkMaterialType.Spined;
				case CraftResource.HornedLeather:	return BulkMaterialType.Horned;
				case CraftResource.BarbedLeather:	return BulkMaterialType.Barbed;
				case CraftResource.DragonLeather:	return BulkMaterialType.DragonL;
				case CraftResource.DaemonLeather:	return BulkMaterialType.Daemon;
				case CraftResource.Pine:		    return BulkMaterialType.Pine;
				case CraftResource.Ash:				return BulkMaterialType.Ash;
				case CraftResource.Mahogany:		return BulkMaterialType.Mahogany;
				case CraftResource.Yew:				return BulkMaterialType.Yew;
				case CraftResource.Oak:				return BulkMaterialType.Oak;
			}

			return BulkMaterialType.None;
		}

		public void EndCombine( Mobile from, object o )
		{
			if ( o is Item && ((Item)o).IsChildOf( from.Backpack ) )
			{
				Type objectType = o.GetType();

				if ( m_AmountCur >= m_AmountMax )
				{
					from.SendLocalizedMessage( 1045166 ); // The maximum amount of requested items have already been combined to this deed.
				}
				else if ( m_Type == null || (objectType != m_Type && !objectType.IsSubclassOf( m_Type )) || (!(o is BaseWeapon) && !(o is BaseArmor) && !(o is BaseClothing) && !(o is BaseRanged) && !(o is BaseStaff) && !(o is BaseShield) && !(o is BaseInstrument)) )
				{
					from.SendLocalizedMessage( 1045169 ); // The item is not in the request.
				}
				else
				{
					BulkMaterialType material = BulkMaterialType.None;
					
					if ( o is BaseArmor )
						material = GetMaterial( ((BaseArmor)o).Resource );
					else if ( o is BaseShoes )
						material = GetMaterial( ((BaseShoes)o).Resource );
					else if ( o is BaseWeapon )
						material = GetMaterial( ((BaseWeapon)o).Resource );
					else if ( o is BaseRanged )
						material = GetMaterial( ((BaseRanged)o).Resource );
					else if ( o is BaseStaff )
						material = GetMaterial( ((BaseStaff)o).Resource );
					else if ( o is BaseShield )
						material = GetMaterial( ((BaseShield)o).Resource );


					if ( m_Material >= BulkMaterialType.DullCopper && m_Material <= BulkMaterialType.Sunstone && material != m_Material )
					{
						from.SendLocalizedMessage( 1045168 ); // The item is not made from the requested ore.
					}
					else if ( m_Material >= BulkMaterialType.Spined && m_Material <= BulkMaterialType.Daemon && material != m_Material )
					{
						from.SendLocalizedMessage( 1049352 ); // The item is not made from the requested leather type.
					}
					else if ( m_Material >= BulkMaterialType.Pine && m_Material <= BulkMaterialType.Oak && material != m_Material )
					{
						from.SendMessage( "The item is not made from the requested wood type." ); // The item is not made from the requested leather type.
					}
					else
					{
						bool isExceptional = false;

						if ( o is BaseWeapon )
							isExceptional = ( ((BaseWeapon)o).Quality == WeaponQuality.Exceptional );
						else if ( o is BaseArmor )
							isExceptional = ( ((BaseArmor)o).Quality == ArmorQuality.Exceptional );
						else if ( o is BaseClothing )
							isExceptional = ( ((BaseClothing)o).Quality == ClothingQuality.Exceptional );
						else if ( o is BaseInstrument )
							isExceptional = ( ((BaseInstrument)o).Quality == InstrumentQuality.Exceptional );
						
						if ( m_RequireExceptional && !isExceptional )
						{
							from.SendLocalizedMessage( 1045167 ); // The item must be exceptional.
						}
						else
						{
							((Item)o).Delete();
							++AmountCur;

							from.SendLocalizedMessage( 1045170 ); // The item has been combined with the deed.

							from.SendGump( new SmallBODGump( from, this ) );

							if ( m_AmountCur < m_AmountMax )
								BeginCombine( from );
						}
					}
				}
			}
			else
			{
				from.SendLocalizedMessage( 1045158 ); // You must have the item in your backpack to target it.
			}
		}
		public SmallBOD( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version

			writer.Write( m_AmountCur );
			writer.Write( m_AmountMax );
			writer.Write( m_Type == null ? null : m_Type.FullName );
			writer.Write( m_Number );
			writer.Write( m_Graphic );
			writer.Write( m_RequireExceptional );
			writer.Write( (int) m_Material );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			switch ( version )
			{
				case 0:
				{
					m_AmountCur = reader.ReadInt();
					m_AmountMax = reader.ReadInt();

					string type = reader.ReadString();

					if ( type != null )
						m_Type = ScriptCompiler.FindTypeByFullName( type );

					m_Number = reader.ReadInt();
					m_Graphic = reader.ReadInt();
					m_RequireExceptional = reader.ReadBool();
					m_Material = (BulkMaterialType)reader.ReadInt();

					break;
				}
			}

			if ( Weight == 0.0 )
				Weight = 1.0;

			if ( Core.AOS && ItemID == 0x14EF )
				ItemID = 0x2258;

			if ( Parent == null && Map == Map.Internal && Location == Point3D.Zero )
				Delete();
		}
	}
}