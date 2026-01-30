from card_game.deck import Deck
# from card_game.deck import shuffle
import random
# Part 1: Create a new deck and deal out all the cards

print("**********")
print("Part 1 - Create a new deck, shuffle, then deal out all the cards")

# Create a new deck
deck = Deck.new_deck()

# TODO: shuffle the deck
print("Shuffling...")
def shuffle(self,times: int=1) ->None:
#     random.shuffle(self._stack)
    n = len(self._stack)
    for i in range(n - 1, 0, -1):
        j = random.randint(0, i)
        self._stack[i], self._stack[j] = self._stack[j], self._stack[i]


# Deal all the cards
while not deck.empty:
    card = deck.next_card()
    print(f"{card.to_short_string()} - {card}")

print("\n**********\n")
