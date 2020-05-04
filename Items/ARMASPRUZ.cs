using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DONKEYMOD.Items
{
  public class ARMASPRUZ : ModItem
  {
    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("ARMASPRUZZ");
      Tooltip.SetDefault("La tua descrizione.");
    }
   item.damage = 900; 
   item.magic = true;
   item.mana = 20;
   item.width = 28;
   item.height = 30;
   item.useTime = 25;
   item.useAnimation = 25;
   item.useStyle = 5;
   item.knockBack = 1f;
   item.value = Item.buyPrice(3, 34, 0, 0);
   item.rare = 5;
   item.noMelee = true;
   item.UseSound = SoundID.Item21;
   item.autoReuse = true;
   item.shoot = ProjectileID.DeathSickle;
   item.shootSpeed = 14f;
  }
      
   