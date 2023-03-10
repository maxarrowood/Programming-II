import random

# Define the card values
card_values = {"Ace": 11, "King": 10, "Queen": 10, "Jack": 10, "10": 10, "9": 9,
               "8": 8, "7": 7, "6": 6, "5": 5, "4": 4, "3": 3, "2": 2}

# Define a function to calculate the value of a hand
def calculate_hand_value(hand):
    # Initialize the hand value to 0
    hand_value = 0
    # Count the number of Aces in the hand
    num_aces = sum([1 for card in hand if card == "Ace"])
    # Add up the values of all the non-Ace cards
    for card in hand:
        if card != "Ace":
            hand_value += card_values[card]
    # Add the value of the Aces, adjusting for the possibility of Aces being worth 1 or 11
    for i in range(num_aces):
        if hand_value + 11 <= 21:
            hand_value += 11
        else:
            hand_value += 1
    return hand_value

# Define the deck of cards
deck = list(card_values.keys()) * 4

# Define the player's hand and the dealer's hand
player_hand = []
dealer_hand = []

# Deal the initial hands
for i in range(2):
    player_hand.append(deck.pop(random.randint(0, len(deck) - 1)))
    dealer_hand.append(deck.pop(random.randint(0, len(deck) - 1)))

# Print the initial hands
print("Your hand:", player_hand)
print("Dealer's hand:", [dealer_hand[0], "X"])

# Define the player's turn
while True:
    choice = input("Do you want to hit or stand? ")
    if choice.lower() == "hit":
        player_hand.append(deck.pop(random.randint(0, len(deck) - 1)))
        print("Your hand:", player_hand)
        if calculate_hand_value(player_hand) > 21:
            print("Bust! You lose.")
            break
    elif choice.lower() == "stand":
        break

# Define the dealer's turn
if calculate_hand_value(player_hand) <= 21:
    print("Dealer's hand:", dealer_hand)
    while calculate_hand_value(dealer_hand) < 17:
        dealer_hand.append(deck.pop(random.randint(0, len(deck) - 1)))
        print("Dealer's hand:", dealer_hand)
        if calculate_hand_value(dealer_hand) > 21:
            print("Dealer busts! You win.")
            break
    if calculate_hand_value(dealer_hand) <= 21:
        if calculate_hand_value(player_hand) > calculate_hand_value(dealer_hand):
            print("You win!")
        elif calculate_hand_value(player_hand) < calculate_hand_value(dealer_hand):
            print("You lose.")
        else:
            print("It's a tie.")
