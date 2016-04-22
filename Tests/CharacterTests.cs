using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    class CharacterTests
    {
        [Test]       
        public void WarriorCreationTest()
        {
            WarriorClass myWarriorToTest = new WarriorClass();
            Assert.AreEqual(myWarriorToTest.Lvl, 0);
            Assert.AreEqual(myWarriorToTest.HPmax, 50);
            Assert.AreEqual(myWarriorToTest.HP, 50);
            Assert.AreEqual(myWarriorToTest.ManaMax, 20);
            Assert.AreEqual(myWarriorToTest.Mana, 20);
            Assert.AreEqual(myWarriorToTest.Damage, 12);
            Assert.AreEqual(myWarriorToTest.CritChance, 22);
            Assert.AreEqual(myWarriorToTest.Speed, 5);
            Assert.AreEqual(myWarriorToTest.HitChance, 60);
            Assert.AreEqual(myWarriorToTest.AffectRes, 30);
        }

        [Test]
        public void WarriorLvlUpTest ()
        {
            WarriorClass myWarriorToTest = new WarriorClass();
            myWarriorToTest.Xp = 150;
            myWarriorToTest.LevelUp();
            Assert.AreEqual(myWarriorToTest.Lvl, 1);
            Assert.AreEqual(myWarriorToTest.HPmax, 65);
            Assert.AreEqual(myWarriorToTest.Xp, 50);
            Assert.AreEqual(myWarriorToTest.XpMax, 200);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void WarriorFailedToLvlUpTest()
        {
            WarriorClass myWarriorToTest = new WarriorClass();
            myWarriorToTest.Xp = 50;
            myWarriorToTest.LevelUp();
            
       }

        [Test]
        public void WarriorGettingSickAndHealTest()
        {
            WarriorClass myWarriorToTest = new WarriorClass();
            Lepre lepre = new Lepre();
            myWarriorToTest.Sickness.Add(lepre);
            lepre.affectToHeros(myWarriorToTest);
            Assert.AreEqual(myWarriorToTest.Damage, 6);
            lepre.cancelAffectToHeros(myWarriorToTest);
            Assert.AreEqual(myWarriorToTest.Damage, 12);
        }
    }
}
