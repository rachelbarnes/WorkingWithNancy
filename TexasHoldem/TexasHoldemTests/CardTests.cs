using NUnit.Framework;
using TexasHoldem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldem.Tests
{
    [TestFixture()]
    public class CardTests
    {
        [Test]
        public void CardTest()
        {
            var QueenOfHearts = new Card('Q', 'H');
            Assert.AreEqual(QueenOfHearts.Rank, 'q');
            Assert.AreEqual(QueenOfHearts.Suit, 'h');
        }
        [Test]
        public void CheckBetValidityTest()
        {
            char[] Hand = new char[] { 'a', 'q' };
            //var PlayerTryingToBet = new Player(Hand, 200, 400);
            //Assert.AreEqual(PlayerTryingToBet.CheckBetValidity(), false);
        }
        [Test]
        public void CheckBetValidityTest2()
        {
            char[] Hand = new char[] { 'a', 'q' };
            //var PlayerTryingToBet = new Player(Hand, 80, 30);
            //Assert.AreEqual(PlayerTryingToBet.CheckBetValidity(), true);
        }
        [Test]
        public void NumberOfCommCardsTest()
        {
            //var FlopRound = new Game();
            //var RoundName = FlopRound.NumberOfCommunityCards("Flop");
            //Assert.AreEqual(RoundName, 3); 
        }

        [Test]
        public void DealCardsWithOnePlayer()
        {
            Game g = Game.start(new List<Player>() {
          new Player() {
            _PlayersHand = new List<Card>(),
            _PlayersAvailableMoneyToBet = 100,
            _Bet = 0,
            type = Player.playerType.small_blind
          }
        });
            var players = g.DealCards();
            Assert.AreEqual(2, players.First()._PlayersHand.Count);

        }

        [Test]
        public void testShuffle()
        {
            //Needs to be done
        }
    }
}