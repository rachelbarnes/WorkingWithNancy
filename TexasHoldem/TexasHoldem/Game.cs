using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldem {
  public interface IGame {
    Player CalculateWinner();
    //List<Player> players { get; set; }
    int pot { get; set; }
  }
  public class Game : IGame {
    public enum Round {
      preflop = 1,
      flop = 2,
      turn = 3,
      river = 4
    }

    public static List<List<T>> Partition<T>(int size, List<T> source) {
      return source
          .Select((x, i) => new { Index = i, Value = x })
          .GroupBy(x => x.Index / size)
          .Select(x => x.Select(v => v.Value).ToList())
          .ToList();
    }

    //Member Variables : What a game has
    private Round round;
    private List<Card> CommunityCards;
    private List<Card> Deck;
    public List<Player> players;
    private Dictionary<Player, int> playerScore;
    //private int Pot;
    //protected abstract Player CalculateWinner(Rules rules);
    private Game(List<Player> regPlayers) {
      //Steps: 
      //1) Shuffle Deck
      //2) Deal Cards
      players = regPlayers;
      this.round = Round.preflop;
      Deck = getDeck();
      //this.DealCards();
    }

    public IEnumerable<Player> DealCards() {
      return players.Zip(Partition(2, Deck), (player, cards) => {
        player._PlayersHand.AddRange(cards);
        return player;
      });
      //foreach (Player player in players) {

      //  player._PlayersHand.Add(Deck[0]);
      //  player._PlayersHand.Add(Deck[1]);
      //}
    }

    public List<Card> getDeck() {
      //Need to get the Cartesian Product of the possible combinations
      var rankPossibilities = new List<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'k', 'q', 'j' };
      var suitPossibilities = new List<char>() { 's', 'h', 'd', 'c' };

      var deck = suitPossibilities.SelectMany(x => rankPossibilities, (x, y) => new Card(y, x)).ToList();
      return Shuffle(deck);
    }

    public List<Card> Shuffle(List<Card> deck) {
            var r = new Random();
      return deck.OrderBy(item => r.Next()).ToList();
    }

    public static Game start(List<Player> registeredPlayers) {
      //Check that we have players before we start a new game
      if (!registeredPlayers.Any() || registeredPlayers.Count > 9)
        return null;
      var game = new Game(registeredPlayers);
      return game;

    }

    public Player CalculateWinner() {
      throw new NotImplementedException();
    }

    public int pot {
      get {
        throw new NotImplementedException();
      }

      set {
        throw new NotImplementedException();
      }
    }

    //public List<Player> players {
    //  get {
    //    return Players; 
    //  }
    //  set {
    //     Players = value;
    //  }
    //}
  }
}