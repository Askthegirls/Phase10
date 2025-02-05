# Phase 10 Score Keeper
Author Sarah K Johnson
Last updated 11-14-2024

Description
A score keeper for playing the Phase 10 card game. The program keeps track of players, their score, what phase they are on, and how many wins they have acquired. Scores and phases are saved per player and deleted after the game has been completed. The player information and win count is saved and available to view on the Scoreboard page. This program is formatted to run best in the Chrome web browser.

Store procedures
GetPlayers: 			Gets the complete list of the full name of all saved players 
GetPlayerStats: 		Gets the Score and Phase values from the table so that they may be 
	displayed and updated during the game
GetWins: 			Gets the win value to be displayed on the Scoreboard page from 
	greatest to least

Functionality
The program has a menu UI that allows the user to select to create a new game, add new players, or view past winners. Once a player creates a new game by selecting the active players, the user is moved to another page to view and update the score as the card game is being played. The game will take in an integer for the score of that round and add it to the players total score. The user also selects whether or not they completed that phase (round) and if the box is checked, then the phase integer is updated to display what phase the player is on. The scores and values are saved to the player selected in the dropdown menu. Once all scores have been recorded, then the user selects “end phase” and the user will enter the next scores after another round.
