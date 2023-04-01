using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void ValuesAboveZero()
        {
            ////////////////////// PLAYER ///////////////////////////////
            Player player1 = new Player("Pepito Peres1",0,Type.Human);
            Player player2 = new Player("Pepito Peres2", -10, Type.Beast);
            Player player3 = new Player("Pepito Peres3", 5, Type.Hybrid);

            Assert.IsNotNull(player1);
            Assert.IsNotNull(player2);
            Assert.IsNotNull(player3);

            Assert.IsTrue(player1.Hp >= 1);
            Assert.IsTrue(player2.Hp >= 1);
            Assert.IsTrue(player3.Hp >= 1);
            //////////////////////////////////////////////////////////////

            //////////////////////// WEAPON /////////////////////////////
            Equipment weapon1 = new Weapon("Arma de Pepito1", 0, 0, Type.Human);
            Equipment weapon2 = new Weapon("Arma de Pepito2", -1,-10, Type.Beast);
            Equipment weapon3 = new Weapon("Arma de Pepito", 0, -5, Type.Hybrid);
            Equipment weapon4 = new Weapon("Arma de Pepito", 0, -5, Type.ANY);

            Assert.IsNotNull(weapon1);
            Assert.IsNotNull(weapon2);
            Assert.IsNotNull(weapon3);
            Assert.IsNotNull(weapon4);

            Assert.IsTrue(weapon1.Val>= 1);
            Assert.IsTrue(weapon1.Dur >= 1);
            Assert.IsTrue(weapon2.Val >= 1);
            Assert.IsTrue(weapon2.Dur >= 1);
            Assert.IsTrue(weapon3.Val >= 1);
            Assert.IsTrue(weapon3.Dur >= 1);
            Assert.IsTrue(weapon4.Val >= 1);
            Assert.IsTrue(weapon4.Dur >= 1);
            /////////////////////////////////////////////////////////////

            ////////////////////////// ARMOR ////////////////////////////

            Equipment armor1 = new Armor("Armadura de Pepito1", 0, 0, Type.Human);
            Equipment armor2 = new Armor("Armadura de Pepito1", -10, -10, Type.Beast);
            Equipment armor3 = new Armor("Armadura de Pepito1", -20, 0, Type.Hybrid);
            Equipment armor4 = new Armor("Armadura de Pepito1", -20, 40, Type.ANY);

            Assert.IsNotNull(armor1);
            Assert.IsNotNull(armor2);
            Assert.IsNotNull(armor3);
            Assert.IsNotNull(armor4);

            Assert.IsTrue(armor1.Val >= 1);
            Assert.IsTrue(armor1.Dur >= 1);
            Assert.IsTrue(armor2.Val >= 1);
            Assert.IsTrue(armor2.Dur >= 1);
            Assert.IsTrue(armor3.Val >= 1);
            Assert.IsTrue(armor3.Dur >= 1);
            Assert.IsTrue(armor4.Val >= 1);
            Assert.IsTrue(armor4.Dur >= 1);
            /////////////////////////////////////////////////////////////
        }

        [TestMethod]
        public void EquipmentTest() 
        {
            Player player1 = new Player("Pepito Peres1", 0, Type.Human);
            Player player2 = new Player("Pepito Peres2", -10, Type.Beast);
            Player player3 = new Player("Pepito Peres3", 5, Type.Hybrid);

            Equipment weapon1 = new Weapon("Arma de Pepito1", 0, 0, Type.Human);
            Equipment weapon2 = new Weapon("Arma de Pepito2", -1, -10, Type.Beast);
            Equipment weapon3 = new Weapon("Arma de Pepito", 0, -5, Type.Hybrid);
            Equipment weapon4 = new Weapon("Arma de Pepito", 0, -5, Type.ANY);

            Equipment armor1 = new Armor("Armadura de Pepito1", 0, 0, Type.Human);
            Equipment armor2 = new Armor("Armadura de Pepito1", -10, -10, Type.Beast);
            Equipment armor3 = new Armor("Armadura de Pepito1", -20, 0, Type.Hybrid);
            Equipment armor4 = new Armor("Armadura de Pepito1", -20, 40, Type.ANY);

            ////////////////////// Weapon Equipe ////////////////////////

            //////////////////////// PLAYER 1 ///////////////////////////

            Assert.IsTrue(player1.EquipeEquipment(weapon1));
            Assert.IsFalse(player1.EquipeEquipment(weapon2));
            Assert.IsFalse(player1.EquipeEquipment(weapon3));
            Assert.IsTrue(player1.EquipeEquipment(weapon4));
            Assert.IsFalse(player1.EquipedWeapon == weapon1);
            Assert.IsFalse(player1.EquipedWeapon == weapon2);
            Assert.IsFalse(player1.EquipedWeapon == weapon3);
            Assert.IsTrue(player1.EquipedWeapon == weapon4);

            /////////////////////// PLAYER 2 ////////////////////////////

            Assert.IsFalse(player2.EquipeEquipment(weapon1));
            Assert.IsTrue(player2.EquipeEquipment(weapon2));
            Assert.IsFalse(player2.EquipeEquipment(weapon3));
            Assert.IsTrue(player2.EquipeEquipment(weapon4));
            Assert.IsFalse(player2.EquipedWeapon == weapon1);
            Assert.IsFalse(player2.EquipedWeapon == weapon2);
            Assert.IsFalse(player2.EquipedWeapon == weapon3);
            Assert.IsTrue(player2.EquipedWeapon == weapon4);

            ////////////////////// PLAYER 3 ////////////////////////////

            Assert.IsFalse(player3.EquipeEquipment(weapon1));
            Assert.IsFalse(player3.EquipeEquipment(weapon2));
            Assert.IsTrue(player3.EquipeEquipment(weapon3));
            Assert.IsTrue(player3.EquipeEquipment(weapon4));
            Assert.IsFalse(player3.EquipedWeapon == weapon1);
            Assert.IsFalse(player3.EquipedWeapon == weapon2);
            Assert.IsFalse(player3.EquipedWeapon == weapon3);
            Assert.IsTrue(player3.EquipedWeapon == weapon4);

            ////////////////////// ARMOR EQUIPE ////////////////////////

            ////////////////////// PLAYER 1 ////////////////////////////

            Assert.IsTrue(player1.EquipeEquipment(armor1));
            Assert.IsFalse(player1.EquipeEquipment(armor2));
            Assert.IsFalse(player1.EquipeEquipment(armor3));
            Assert.IsTrue(player1.EquipeEquipment(armor4));
            Assert.IsFalse(player1.EquipedArmor == armor1);
            Assert.IsFalse(player1.EquipedArmor == armor2);
            Assert.IsFalse(player1.EquipedArmor == armor3);
            Assert.IsTrue(player1.EquipedArmor == armor4);

            ////////////////////// PLAYER 2 ////////////////////////////

            Assert.IsFalse(player2.EquipeEquipment(armor1));
            Assert.IsTrue(player2.EquipeEquipment(armor2));
            Assert.IsFalse(player2.EquipeEquipment(armor3));
            Assert.IsTrue(player2.EquipeEquipment(armor4));
            Assert.IsFalse(player2.EquipedArmor == armor1);
            Assert.IsFalse(player2.EquipedArmor == armor2);
            Assert.IsFalse(player2.EquipedArmor == armor3);
            Assert.IsTrue(player2.EquipedArmor == armor4);

            ////////////////////// PLAYER 2 ////////////////////////////

            Assert.IsFalse(player3.EquipeEquipment(armor1));
            Assert.IsFalse(player3.EquipeEquipment(armor2));
            Assert.IsTrue(player3.EquipeEquipment(armor3));
            Assert.IsTrue(player3.EquipeEquipment(armor4));
            Assert.IsFalse(player2.EquipedArmor == armor1);
            Assert.IsFalse(player2.EquipedArmor == armor2);
            Assert.IsFalse(player2.EquipedArmor == armor3);
            Assert.IsTrue(player2.EquipedArmor == armor4);

            ////////////////////////////////////////////////////////////
        }

        [TestMethod]
        public void DurabilityCheck() 
        {
            Player p1,p2;
            Equipment w1, w2, a1, a2;
            ResetParameter(out p1, out p2, out a1, out a2, out w1, out w2);

            p1.EquipeEquipment(w1);
            p1.EquipeEquipment(a1);
            p2.EquipeEquipment(w2);
            p2.EquipeEquipment(a2);

            GameManager.Instance.CombatSimulator1turnEach(p1, p2);

            Assert.IsTrue(p1.EquipedWeapon.Dur < 5);
            Assert.IsTrue(p1.EquipedArmor.Dur < 100);
            Assert.IsTrue(p2.EquipedWeapon.Dur < 10);
            Assert.IsTrue(p2.EquipedArmor.Dur < 200);
        }

        [TestMethod]
        public void TakeDamageNoArmor() 
        {
            Player p1, p2;
            Equipment w1, w2, a1, a2;
            ResetParameter(out p1, out p2, out a1, out a2, out w1, out w2);

            p1.EquipeEquipment(w1);
            p1.EquipeEquipment(a1);

            GameManager.Instance.CombatSimulator1turnEach(p1, p2);

            Assert.IsTrue(p2.Hp == 100 - 10);
        }

        [TestMethod]
        public void TakeDamageWhitArmor() 
        {
            Player p1, p2;
            Equipment w1, w2, a1, a2;
            ResetParameter(out p1, out p2, out a1, out a2, out w1, out w2);

            p1.EquipeEquipment(w1);
            p1.EquipeEquipment(a1);
            p2.EquipeEquipment(w2);
            p2.EquipeEquipment(a2);

            GameManager.Instance.CombatSimulator1turnEach(p1, p2);

            Assert.IsTrue(p1.EquipedArmor.Dur == 100 - 10);
            Assert.IsTrue(p2.EquipedArmor.Dur == 200 - 5);
            Assert.IsTrue(p1.Hp == 100);
            Assert.IsTrue(p2.Hp == 100);
        }

        [TestMethod]
        public void DealDamageNoWeapon() 
        {
            Player p1, p2;
            Equipment w1, w2, a1, a2;
            ResetParameter(out p1, out p2, out a1, out a2, out w1, out w2);

            p2.EquipeEquipment(w2);
            p2.EquipeEquipment(a2);

            GameManager.Instance.CombatSimulator1turnEach(p1, p2);

            Assert.IsTrue(p2.EquipedArmor.Dur == 200 - 2);

            ResetParameter(out p1, out p2, out a1, out a2, out w1, out w2);

            p2.EquipeEquipment(w2);
            p2.EquipeEquipment(a2);

            p1.BaseAtk = 0;

            GameManager.Instance.CombatSimulator1turnEach(p1, p2);

            Assert.IsTrue(p2.EquipedArmor.Dur < 200);
        }

        [TestMethod]
        public void DealDamageNoWeaponNoArmor() 
        {
            Player p1, p2;
            Equipment w1, w2, a1, a2;
            ResetParameter(out p1, out p2, out a1, out a2, out w1, out w2);

            GameManager.Instance.CombatSimulator1turnEach(p1, p2);

            Assert.IsTrue(p1.Hp == 100 - 5);
            Assert.IsTrue(p2.Hp == 100 - 5);
        }

        [TestMethod]
        public void OneDurabilityEquipment() 
        {
            Player p1, p2;
            Equipment w1, w2, a1, a2;
            ResetParameter(out p1, out p2, out a1, out a2, out w1, out w2);

            p1.EquipeEquipment(w1);
            p1.EquipeEquipment(a1);
            p2.EquipeEquipment(w2);
            p2.EquipeEquipment(a2);

            p1.EquipedArmor.ReduceDurability(199);

            for (int i = 0; i <= 3; i++)
            {
                p1.EquipedWeapon.ReduceDurability();
            }

            GameManager.Instance.CombatSimulator1turnEach(p1, p2);

            Assert.IsTrue(p1.EquipedWeapon == null);
            Assert.IsTrue(p1.EquipedArmor == null);
        }

        [TestMethod]
        public void NoNegativeValueHP() 
        {
            Player p1, p2;
            Equipment w1, w2, a1, a2;
            ResetParameter(out p1, out p2, out a1, out a2, out w1, out w2);
            p1.TakeDamage(99);

            GameManager.Instance.CombatSimulator1turnEach(p1, p2);

            Assert.IsTrue(p1.Hp == 0);
        }

        [TestMethod]
        public void NoNegativeValueArmorDur() 
        {
            Player p1, p2;
            Equipment w1, w2, a1, a2;
            ResetParameter(out p1, out p2, out a1, out a2, out w1, out w2);

            p1.EquipeEquipment(w1);
            p1.EquipeEquipment(a1);
            p2.EquipeEquipment(w2);
            p2.EquipeEquipment(a2);

            p1.EquipedArmor.ReduceDurability(199);

            GameManager.Instance.CombatSimulator1turnEach(p1, p2);

            Assert.IsTrue(a1.Dur == 0);
        }

        [TestMethod]
        public void ZeroDurabilityEquipment() 
        {
            Player p1, p2;
            Equipment w1, w2, a1, a2;
            ResetParameter(out p1, out p2, out a1, out a2, out w1, out w2);

            Weapon F = new Weapon("N", 2, 5, Type.Human);
            Armor D = new Armor("D",2,100,Type.Human);

            for (int i = 0; i < 5; i++)
            {
                F.ReduceDurability();
            }

            D.ReduceDurability(500);

            Assert.IsFalse(p1.EquipeEquipment(F));
            Assert.IsFalse(p1.EquipeEquipment(D));
        }
        public void ResetParameter(out Player p1, out Player p2, out Equipment a1, out Equipment a2, out Equipment w1, out Equipment w2)
        {
            p1 = new Player("Pepito peres1", 100, Type.Human);
            p2 = new Player("Pepito peres2", 100, Type.Beast);
            w1 = new Weapon("Arma de Pepito1", 10, 5, Type.Human);
            w2 = new Weapon("Arma de Pepito2", 20, 10, Type.Beast);
            a1 = new Armor("Armadura de Pepito1", 10, 100, Type.Human);
            a2 = new Armor("Armadura de Pepito1", 20, 200, Type.Beast);
        }
    }

    
}
