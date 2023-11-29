import React, { useState } from 'react';
import { Text, View, TouchableOpacity } from 'react-native';

export default function Screen2() {
  const [cells, setCells] = useState(() => {
    const grid = Array(10)
      .fill('')
      .map(() => Array(10).fill(''));

    const words = ['ppa', 'system', 'software', 'repoleved', 'mobile', 'phone'];
    const direction = [0, 0, 1, 1, 2, 3];

    // Place words randomly
    let pos = 0;
    for (const word of words) {
      let placed = false;
      while (!placed) {
        const row = Math.floor(Math.random() * 10);
        const col = Math.floor(Math.random() * 10);

        if (direction[pos] === 0) {
          if (col + word.length <= 10) {
            let valid = true;
            for (let i = 0; i < word.length; i++) {
              if (grid[row][col + i] !== '') {
                valid = false;
                break;
              }
            }
            if (valid) {
              for (let i = 0; i < word.length; i++) {
                grid[row][col + i] = {
                  letter: word[i],
                };
              }
              placed = true;
            }
          }
        } else if (direction[pos] === 1) {
          if (row + word.length <= 10) {
            let valid = true;
            for (let i = 0; i < word.length; i++) {
              if (grid[row + i][col] !== '') {
                valid = false;
                break;
              }
            }
            if (valid) {
              for (let i = 0; i < word.length; i++) {
                grid[row + i][col] = {
                  letter: word[i],
                };
              }
              placed = true;
            }
          }
        } else if (direction[pos] === 2) {
          if (row + word.length <= 10 && col - word.length >= 0) {
            let valid = true;
            for (let i = 0; i < word.length; i++) {
              if (grid[row + i][col - i] !== '') {
                valid = false;
                break;
              }
            }
            if (valid) {
              for (let i = 0; i < word.length; i++) {
                grid[row + i][col - i] = {
                  letter: word[i],
                };
              }
              placed = true;
            }
          }
        } else if (direction[pos] === 3) {
          if (row + word.length <= 10 && col + word.length <= 10) {
            let valid = true;
            for (let i = 0; i < word.length; i++) {
              if (grid[row + i][col + i] !== '') {
                valid = false;
                break;
              }
            }
            if (valid) {
              for (let i = 0; i < word.length; i++) {
                grid[row + i][col + i] = {
                  letter: word[i],
                };
              }
              placed = true;
            }
          }
        }
      }
      pos++;
    }

    const alphabet = 'abcdefghijklmnopqrstuvwxyz';

    for (let row = 0; row < 10; row++) {
      for (let col = 0; col < 10; col++) {
        if (grid[row][col] === '') {
          const randomLetterIndex = Math.floor(Math.random() * alphabet.length);
          grid[row][col] = {
            letter: alphabet[randomLetterIndex],
          };
        }
      }
    }

    return grid.flat();
  });

  const [showGrid, setShowGrid] = useState(false);

  const handlePress = (index) => {
    const updatedCells = [...cells];
    const cell = updatedCells[index];
    if (cell.color === 'blue') {
      cell.color = 'white';
    } else {
      cell.color = 'blue';
    }
    updatedCells[index] = cell;
    setCells(updatedCells);
  };

  const handleTitlePress = () => {
    setShowGrid(true);
  };

  return (
    <View style={{ flex: 1, justifyContent: 'center', alignItems: 'center' }}>
      <Text
        onPress={handleTitlePress}
        style={{ fontSize: 40, marginVertical: 20, fontWeight: 'bold' }}>
        Sopa de letras
      </Text>
      {showGrid && (
        <View style={{ flexDirection: 'row', flexWrap: 'wrap' }}>
          {cells.map((cell, index) => (
            <Text
              key={index}
              style={{
                backgroundColor: cell.color,
                width: 38,
                padding: 14,
                borderWidth: 1,
                justifyContent: 'center',
                alignItems: 'center',
              }}
              onPress={() => handlePress(index)}>
              {cell.letter}
            </Text>
          ))}
        </View>
      )}
    </View>
  );
}
