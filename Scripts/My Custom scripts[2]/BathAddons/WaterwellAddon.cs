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
    public class WaterwellAddon : BaseAddon
    {
        public override BaseAddonDeed Deed
        {
            get
            {
                return new WaterwellAddonDeed();
            }
        }

        [Constructable]
        public WaterwellAddon()
        {
            AddonComponent ac;
            ac = new AddonComponent(490);
            AddComponent(ac, -1, 1, 0);
            ac = new AddonComponent(490);
            AddComponent(ac, -1, 0, 0);
            ac = new AddonComponent(490);
            AddComponent(ac, -1, 0, 3);
            ac = new AddonComponent(490);
            AddComponent(ac, -1, 1, 3);
            ac = new AddonComponent(491);
            AddComponent(ac, -1, -1, 3);
            ac = new AddonComponent(8564);
            AddComponent(ac, -1, 1, 12);
            ac = new AddonComponent(8564);
            AddComponent(ac, -1, 0, 12);
            ac = new AddonComponent(8564);
            AddComponent(ac, -1, -1, 12);
            ac = new AddonComponent(488);
            AddComponent(ac, 1, 1, 0);
            ac = new AddonComponent(488);
            AddComponent(ac, 1, 1, 3);
            ac = new AddonComponent(490);
            AddComponent(ac, 1, 0, 0);
            ac = new AddonComponent(490);
            AddComponent(ac, 1, 0, 3);
            ac = new AddonComponent(489);
            AddComponent(ac, 0, 1, 0);
            ac = new AddonComponent(489);
            AddComponent(ac, 0, 1, 3);
            ac = new AddonComponent(489);
            AddComponent(ac, 1, -1, 0);
            ac = new AddonComponent(489);
            AddComponent(ac, 1, -1, 3);
            ac = new AddonComponent(489);
            AddComponent(ac, 0, -1, 0);
            ac = new AddonComponent(489);
            AddComponent(ac, 0, -1, 3);
            ac = new AddonComponent(10403);
            AddComponent(ac, 0, 1, 3);
            ac = new AddonComponent(10403);
            AddComponent(ac, 0, -1, 3);
            ac = new AddonComponent(6039);
            AddComponent(ac, 0, 0, 0);
            ac = new AddonComponent(1474);
            AddComponent(ac, 0, 1, 15);
            ac = new AddonComponent(1474);
            AddComponent(ac, 0, 0, 15);
            ac = new AddonComponent(1474);
            AddComponent(ac, 0, -1, 15);
            ac = new AddonComponent(8560);
            AddComponent(ac, 1, 1, 12);
            ac = new AddonComponent(8560);
            AddComponent(ac, 1, 0, 12);
            ac = new AddonComponent(8560);
            AddComponent(ac, 1, -1, 12);
            ac = new AddonComponent(5368);
            AddComponent(ac, 1, 1, 6);
            ac = new AddonComponent(4090);
            AddComponent(ac, 1, 0, 6);

        }
        public override void OnComponentUsed(AddonComponent ac, Mobile from)
        {
            if (!from.InRange(GetWorldLocation(), 2))
                from.SendMessage("You are too far away.");
            else
            {
                if (0.20 >= Utility.RandomDouble())
                {
                    from.SendMessage("As you raise the water bucket from the well you notice a fishing net!");
                    from.AddToBackpack(new SpecialFishingNet());
                }

                else
                {
                    switch (Utility.Random(5))
                    {
                        default:
                        case 0:
                            {
                                from.Say("You lower the bucket into the well and draw up some cool, fresh water.");
                                from.PlaySound(0x4E);
                                break;
                            }
                        case 1:
                            {
                                from.Say("I wouldnt worry about the frog SPIT, but you dont want to think about what else it does in here.");
                                from.PlaySound(0x4E);
                                break;
                            }

                        case 2:
                            {
                                from.Say("Hey... You ever gonna get this corpse out of here? Its smelling up the place..");
                                from.PlaySound(0x4E);
                                break;
                            }

                        case 3:
                            {
                                from.Say("Frog ate most of the flies, but.. what ate half the frog?");
                                from.PlaySound(0x4E);
                                break;
                            }
                        case 4:
                            {
                                from.Say("Best Artesian water around... yep.. those Artesians are always *watering* in here...");
                                from.PlaySound(0x4E);
                                break;
                            }
                    }
                }
            }
        }
        public WaterwellAddon(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0); // Version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }

    public class WaterwellAddonDeed : BaseAddonDeed
    {
        public override BaseAddon Addon
        {
            get
            {
                return new WaterwellAddon();
            }
        }

        [Constructable]
        public WaterwellAddonDeed()
        {
            Name = "Waterwell";
        }

        public WaterwellAddonDeed(Serial serial)
            : base(serial)
        {

        }
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            switch (version)
            {
                case 0:
                    {
                        break;
                    }
            }
        }
    }
}


