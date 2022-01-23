# Unus

#### An open source card game that totally isn't just Uno why would it be Uno that's just dumb.

## Okay, so how do you play Unus

- Every player gets 7 cards to begin
- The first card off the top of the deck gets put in the middle. This will be the first card to match. 
- A random player is chosen to be first.
- The player will look at their cards, find a card that matches the one in the middle by either color or number/type
- The can place that card down, then their turn ends unless it's one of the special cards
- If the player has no cards that match, they must draw cards until they find one they can play. 
- If the deck runs out of cards for drawing, the center pile is reshuffled except for the top most card
- When a player plays a card that leaves them with only one card in their deck, they must declare Unus, or if a player calls them out for not saying Unus they have to draw 3 cards
- The first person to get rid of all their cards wins. 

Wait but that's ju-

#### Shut up.

## Special cards

- Plus 2
  - Makes the next person get 2 cards from the deck
  - If the next player has a Plus 2 card, they can stack it to transfer 4 cards to the next player in line. 
- Reverse 
  - Changes the direction of play
- Skip
  - Skips the turn of the next player
- Color 
  - Can be played over any color, and allows the player to change what color the top card of the deck is
- Color +4
  - Same as a color card, except the next player also has to get 4 cards. Can be stacked like a plus 2

## Possible card sets

### Unus Color Plus

Adds new Color cards

- Color target +2
- Color swap hands
- Color double skip
- Color skip
- Color reverse

### Unus Dark

Cards have two sides, light and dark. 

A special switch sides card changes which sides are in play when discarded.

## Prototypes

### Deck Prototype

This is a console application that tests the Deck, Hand, and Card related classes. It creates a new Deck, fills it with standard cards, shuffles it, and deals it out to the player Hands.

### Playable Card Detection Prototype

This console application tests code for seeing what cards can be played based on the discard pile's top card. Also tests drawing untill a playable card is found. Finally, tests code for playing a card.

### To-Do

- Unus Bot Prototype
  
  - Will test code for a bot player. The bot will be able to randomly pick a playable card from their stack, draw more cards if there are no playable cards in it's hand, and have a random chance to call unus.
  
  - Console Application

- Game Prototype
  
  - Single player with 3 bots
  
  - Console Application
  
  - This will be a fully playable game of Unus.

- WASDK 1.0: Singleplayer
  
  - Converts the console game prototype to the WASDK for a proper GUI

- Multiplayer Server + Client Prototype
  
  - This will be the actual Server as well as a prototype for the client code to test the server connection
  
  - Both Console Applications

- Game Prototype 2
  
  - Multiplayer prototype
  
  - Console Application
  
  - Bots fill up extra slots if there are less than 4 players

- WASDK 2.0: Multiplayer
  
  - Update to the WASDK Unus to add multiplayer code and server support

#### Bonus

- Deck sets prototype
  
  - Test filling the deck with different card sets, like Unus Color Plus or Unus Dark 
  
  - Console Application

- Game Prototype 3
  
  - Console Application
  
  - Tests selecting other card sets for play

- Game Prototype 4
  
  - Console Application
  
  - Tests selecting other card sets with multiplayer games

- WASDK 3.0: New Card Sets
  
  - Update to the WASDK Unus to add the new card sets and card set support.
