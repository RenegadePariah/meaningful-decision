1. Description

Go through the binary decisions and reach the end. Puzzles must be solved and choices must be taken.

---

2. Installation instructions

For windows:  
	- download and extract the files  
	- install java on your machine  
	- run “java -jar MeaningfulDecision.jar” in a command shell at the appropriate file location.

For linux:  
	- download and extract the files  
	- install java on your machine  
	- run “java -jar MeaningfulDecision.jar” in a command shell at the appropriate file location.

---

3. Command parameters

"java -jar MeaningfulDecision.jar [scenario_path] [override_seed]"

scenario_path: the path to the scenario to play

random_seed: overrides the scenario's random seed configuration

default scenario_path: res/scenarios/default

default random_seed: (not fixed)

---

4. Key bindings

A: move left

D: move right

W: jump up

S: jump down

Space: change player's color

Escape: exit the game

F5: restart game

F11: toggle fullscreen

---

5. Instructions

Solve puzzles by clearing a path through the many blocks. The exit of all puzzles except the final puzzle follows the direction of gravity.

Blocks may be merged, swapped, backtracked or destroyed. Block behavior is prompted by player collision. Primary color blocks are red, green and blue. They are associated to red, green and blue currency respectively. Secondary color blocks are yellow, pink, and cyan. They are associated with red/green, red/blue and green/blue currency respectively. White, grey and black blocks have special behavior. White and black blocks are associated to all currencies, while grey blocks are associated with none.

Merging: Only primary and secondary color blocks may be merged by pushing them on identically colored blocks. Additionally, secondary color blocks may be pushed on a related primary color block.
	Red blocks can be merged with red blocks, providing red currency.
	Green blocks can be merged with green blocks, providing green currency.
	Blue blocks can be merged with blue blocks, providing blue currency.
	Yellow blocks can be merged with yellow blocks, providing red and green currency.
	Pink blocks can be merged with pink blocks, providing red and blue currency.
	Cyan blocks can be merged with cyan blocks, providing green and blue currency.
	Cyan blocks can be merged with green blocks, providing green currency, and leaving a blue block.
	Cyan blocks can be merged with blue blocks, providing blue currency, and leaving a green block.
	Secondary color blocks can be merged with primary color blocks, providing the mutually held currency, and changing the color to the remaining primary value.

Swapping: The player may change their color to enable swaping with blocks of the same color. Primary color, secondary color, and white blocks may be swapped with the player (they may exchange places). A swap costs the respective currency to perform. The currency balance is allowed to be negative for white blocks only (the player must have a positive red currency balance in order to exchange places with a red block).

Backtrack: All blocks except white blocks may be removed when moving from right to left. The currency balance is allowed to be negative. Using backtrack (and swaps on white blocks) a player is always able to exit a puzzle.

Destruction: Grey blocks are removed upon contact, at no cost.

The final puzzle operates on different rules. Each block must be destroyed by colliding with them, at their respective cost. If the player attempts to destroy a block with a negative currency balance (in that particular currency), they trigger the losing condition. The winning condition is triggered by moving past the final block of the final puzzle (exit the game on the right side).

The player may always regenerate the scenario if any of their currency balances is null or negative by moving left past the first corridor (they exit the game on the left side). If their balance is positive in all currencies, they are not able to exit this way. A regenerated scenario is exactly identical to what the player attempted to solve originally. A simple restart, in contrast, would change the seed of the scenario if it was not fixed, as well as change the layout of the puzzles.

A seed is fixed either by specifying it in the scenario settings file or by override as a console argument.

---

6. Modding

This game possesses modding capabilities. In order to create a mod: 1) create a file in <game.file>/res/scenarios 2) create a file 'decisions', and populate it with images (at least 4) 3) optionally create a 'settings' text file.

Fields of the 'settings' text file:

scenario.seed allows to fix the scenario to a specific series of decisions, 
tree.depth is the number of branches (2^n-1), 
tree.length.max is the maximal size of a decision string, 
tree.length.start is the initial size of a decision string, 
count.color is the number of available colors to shade a decision character, 
size.puzzle is the size of puzzles (width and height), 
currency.start is the starting currency of the player (equal for all three currencies), 
currency.end is the currency the player must spend to win the game in the final puzzle (equal for all three currencies), 
difficulty.minimum determines the minimum difficulty of a puzzle, 
difficulty.maximum determines the maximum difficulty of a puzzle, 
ratio.mutation is the likelihood that decision strings receives more than one character change from parent to child (inheritance), 
ratio.surprise is the likelihood that one character of a decision is only revealed at the end, 
rate.insertion is the likelihood for decision strings to inherit a new character, 
rate.deletion is the likelihood for decision strings to lose an inherited character, 
rate.incrementation is the likelihood for decision strings to change the progress of an inherited character (negatively or positively), 
rate.coloration is the likelihood for decision strings to change the color of an inherited character 

Assign a value to a field by writting <field.name><whitespace><field.value> on one line. The field's ultimate value will be the last assignment for that field in the file.

Comment using the ';' character.

---

7. Bugs/updates

There will be no fix nor maintenance of any kind.
