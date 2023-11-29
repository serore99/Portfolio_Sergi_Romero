import { useCallback, useState, useEffect } from 'react';
import { TextInput, Text, ScrollView, View } from 'react-native';

const WORDS = ["software", "developer", "system", "app", "framework"]
const INDEX_INTERSECTIONS = [{ wordIndex: 1, characterIndex: [1, 5] }, { wordIndex: 2, characterIndex: [3, 3] }, { wordIndex: 3, characterIndex: [5, 0] }, { wordIndex: 4, characterIndex: [7, 4] }]

const InputWord = ({ handleSetInputWord, value }) => (
  <View style={{ padding: 2, borderWidth: 1 }}>
    <TextInput value={value} placeholder={''} size="20" defaultValue="" maxLength={1} onChangeText={character => handleSetInputWord(character)} />
  </View>
)

export default function Screen1() {
  const [showDefinitions, setShowDefinitions] = useState(false)
  const [definitions, setDefinitions] = useState([])
  const [inputsWords, setInputsWords] = useState(WORDS.map((word) => Array(word.length).fill('')))

  const getWord = async (word) => {
    const response = await fetch(`https://api.dictionaryapi.dev/api/v2/entries/en/${word}`);
    return await response.json();
  }

  const getWords = async () => {
    const words = await Promise.all(WORDS.map(async (word) => getWord(word)));

    setDefinitions(words.reduce((acc, word) => {
      return [
        ...acc,
        word[0].meanings[0].definitions[0].definition
      ]
    }, []))
  }

  useEffect(() => {
    getWords()
  }, [])

  const handleShowDefinitions = useCallback(() => {
    setShowDefinitions(actualValue => !actualValue)
  }, [])

  const handleSetInputWord = useCallback(({ wordIndex, characterIndex, character }) => {
    setInputsWords(actualValue => {
      const newInputsWords = [...actualValue]
      newInputsWords[wordIndex][characterIndex] = character
      return newInputsWords
    })
  }, [])

  const validateWord = useCallback(({ wordIndex }) => {
    WORDS[wordIndex].split('').forEach((character, index) => {
      if (character !== inputsWords[wordIndex][index]) {
        handleSetInputWord({
          wordIndex,
          characterIndex: index,
          character: ""
        })

        if (wordIndex === 0) {
          INDEX_INTERSECTIONS.forEach(intersection => {
            if (intersection.characterIndex[0] === index) {
              handleSetInputWord({
                wordIndex: intersection.wordIndex,
                characterIndex: intersection.characterIndex[1],
                character: ""
              })
            }
          })
        }
      }
    }
    )
  }, [inputsWords])

  return (
    <View
      style={{
        justifyContent: 'center',
        alignSelf: 'center',
        marginVertical: 80,
      }}>
      <Text style={{ fontSize: 40, marginVertical: 20, fontWeight: 'bold' }} onPress={handleShowDefinitions}>
        Crossroads
      </Text>
      <View style={{ justifyContent: 'center', alignItems: 'center' }}>
        <View style={{ flexDirection: 'row' }}>
          <View style={{ flexDirection: 'column' }}>
            <View style={{ flexDirection: 'column' }}>
              <View style={{ flexDirection: 'row' }}>
                <View style={{ width: 134 }}></View>
                <View style={{ width: 16 }} >
                  <Text style={{ fontSize: 20 }} onPress={() => validateWord({ wordIndex: 0 })}>1</Text>
                </View>
                <InputWord
                  value={inputsWords[0][0]}
                  handleSetInputWord={(character) => handleSetInputWord({
                    wordIndex: 0,
                    characterIndex: 0,
                    character
                  })} />
              </View>

              <View style={{ flexDirection: 'row' }}>
                <View style={{ width: 16 }} >
                  <Text style={{ fontSize: 20 }} onPress={() => validateWord({ wordIndex: 1 })}>2</Text>
                </View>
                <InputWord
                  value={inputsWords[1][0]}
                  handleSetInputWord={(character) => handleSetInputWord({
                    wordIndex: 1,
                    characterIndex: 0,
                    character
                  })} />
                <InputWord
                  value={inputsWords[1][1]}
                  handleSetInputWord={(character) => handleSetInputWord({
                    wordIndex: 1,
                    characterIndex: 1,
                    character
                  })} />
                <InputWord
                  value={inputsWords[1][2]}
                  handleSetInputWord={(character) => handleSetInputWord({
                    wordIndex: 1,
                    characterIndex: 2,
                    character
                  })} />
                <InputWord
                  value={inputsWords[1][3]}
                  handleSetInputWord={(character) => handleSetInputWord({
                    wordIndex: 1,
                    characterIndex: 3,
                    character
                  })} />
                <InputWord
                  value={inputsWords[1][4]}
                  handleSetInputWord={(character) => handleSetInputWord({
                    wordIndex: 1,
                    characterIndex: 4,
                    character
                  })} />
                <InputWord
                  value={inputsWords[1][5]}
                  handleSetInputWord={(character) => {
                    handleSetInputWord({
                      wordIndex: 1,
                      characterIndex: 5,
                      character
                    })
                    handleSetInputWord({
                      wordIndex: 0,
                      characterIndex: 1,
                      character
                    })
                  }} />
                <InputWord
                  value={inputsWords[1][6]}
                  handleSetInputWord={(character) => handleSetInputWord({
                    wordIndex: 1,
                    characterIndex: 6,
                    character
                  })} />
                <InputWord
                  value={inputsWords[1][7]}
                  handleSetInputWord={(character) => handleSetInputWord({
                    wordIndex: 1,
                    characterIndex: 7,
                    character
                  })} />
                <InputWord
                  value={inputsWords[1][8]}
                  handleSetInputWord={(character) => handleSetInputWord({
                    wordIndex: 1,
                    characterIndex: 8,
                    character
                  })} />
              </View>

              <View style={{ flexDirection: 'row' }}>
                <View style={{ width: 150 }}></View>
                <InputWord
                  value={inputsWords[0][2]}
                  handleSetInputWord={(character) => handleSetInputWord({
                    wordIndex: 0,
                    characterIndex: 2,
                    character
                  })} />
              </View>

              <View style={{ flexDirection: 'row' }}>
                <View style={{ width: 54 }}></View>
                <View style={{ width: 16 }} >
                  <Text style={{ fontSize: 20 }} onPress={() => validateWord({ wordIndex: 2 })}>3</Text>
                </View>
                <InputWord
                  value={inputsWords[2][0]}
                  handleSetInputWord={(character) => handleSetInputWord({
                    wordIndex: 2,
                    characterIndex: 0,
                    character
                  })} />
                <InputWord
                  value={inputsWords[2][1]}
                  handleSetInputWord={(character) => handleSetInputWord({
                    wordIndex: 2,
                    characterIndex: 1,
                    character
                  })} />
                <InputWord
                  value={inputsWords[2][2]}
                  handleSetInputWord={(character) => handleSetInputWord({
                    wordIndex: 2,
                    characterIndex: 2,
                    character
                  })} />
                <InputWord
                  value={inputsWords[2][3]}
                  handleSetInputWord={(character) => {
                    handleSetInputWord({
                      wordIndex: 2,
                      characterIndex: 3,
                      character
                    })
                    handleSetInputWord({
                      wordIndex: 0,
                      characterIndex: 3,
                      character
                    })
                  }
                  } />
                <InputWord
                  value={inputsWords[2][4]}
                  handleSetInputWord={(character) => handleSetInputWord({
                    wordIndex: 2,
                    characterIndex: 4,
                    character
                  })} />
                <InputWord
                  value={inputsWords[2][5]}
                  handleSetInputWord={(character) => handleSetInputWord({
                    wordIndex: 2,
                    characterIndex: 5,
                    character
                  })} />
                <View style={{ width: 64 }}></View>
              </View>

              <View style={{ flexDirection: 'row' }}>
                <View style={{ width: 150 }}></View>
                <InputWord
                  value={inputsWords[0][4]}
                  handleSetInputWord={(character) => handleSetInputWord({
                    wordIndex: 0,
                    characterIndex: 4,
                    character
                  })} />
              </View>

              <View style={{ flexDirection: 'row' }}>
                <View style={{ width: 134 }}></View>
                <View style={{ width: 16 }}>
                  <Text style={{ fontSize: 20 }} onPress={() => validateWord({ wordIndex: 3 })}>4</Text>
                </View>
                <InputWord
                  value={inputsWords[3][0]}
                  handleSetInputWord={(character) => {

                    handleSetInputWord({
                      wordIndex: 3,
                      characterIndex: 0,
                      character
                    })

                    handleSetInputWord({
                      wordIndex: 0,
                      characterIndex: 5,
                      character
                    })
                  }
                  } />
                <InputWord
                  value={inputsWords[3][1]}
                  handleSetInputWord={(character) => handleSetInputWord({
                    wordIndex: 3,
                    characterIndex: 1,
                    character
                  })} />
                <InputWord
                  value={inputsWords[3][2]}
                  handleSetInputWord={(character) => handleSetInputWord({
                    wordIndex: 3,
                    characterIndex: 2,
                    character
                  })} />
                <View style={{ width: 64 }}></View>
              </View>

              <View style={{ flexDirection: 'row' }}>
                <View style={{ width: 150 }}></View>
                <InputWord
                  value={inputsWords[0][6]}
                  handleSetInputWord={(character) => handleSetInputWord({
                    wordIndex: 0,
                    characterIndex: 6,
                    character
                  })} />
              </View>

              <View style={{ flexDirection: 'row' }}>
                <View style={{ width: 27 }}></View>
                <View style={{ width: 16 }} >
                  <Text style={{ fontSize: 20 }} onPress={() => validateWord({ wordIndex: 4 })}>5</Text>
                </View>
                <InputWord
                  value={inputsWords[4][0]}
                  handleSetInputWord={(character) => handleSetInputWord({
                    wordIndex: 4,
                    characterIndex: 0,
                    character
                  })} />
                <InputWord
                  value={inputsWords[4][1]}
                  handleSetInputWord={(character) => handleSetInputWord({
                    wordIndex: 4,
                    characterIndex: 1,
                    character
                  })} />
                <InputWord
                  value={inputsWords[4][2]}
                  handleSetInputWord={(character) => handleSetInputWord({
                    wordIndex: 4,
                    characterIndex: 2,
                    character
                  })} />
                <InputWord
                  value={inputsWords[4][3]}
                  handleSetInputWord={(character) => handleSetInputWord({
                    wordIndex: 4,
                    characterIndex: 3,
                    character
                  })} />
                <InputWord
                  value={inputsWords[4][4]}
                  handleSetInputWord={(character) => {
                    handleSetInputWord({
                      wordIndex: 4,
                      characterIndex: 4,
                      character
                    })
                    handleSetInputWord({
                      wordIndex: 0,
                      characterIndex: 7,
                      character
                    })
                  }} />
                <InputWord
                  value={inputsWords[4][5]}
                  handleSetInputWord={(character) => handleSetInputWord({
                    wordIndex: 4,
                    characterIndex: 5,
                    character
                  })} />
                <InputWord
                  value={inputsWords[4][6]}
                  handleSetInputWord={(character) => handleSetInputWord({
                    wordIndex: 4,
                    characterIndex: 6,
                    character
                  })} />
                <InputWord
                  value={inputsWords[4][7]}
                  handleSetInputWord={(character) => handleSetInputWord({
                    wordIndex: 4,
                    characterIndex: 7,
                    character
                  })} />
                <InputWord
                  value={inputsWords[4][8]}
                  handleSetInputWord={(character) => handleSetInputWord({
                    wordIndex: 4,
                    characterIndex: 8,
                    character
                  })} />
              </View>
            </View>
          </View>
        </View>

        <ScrollView>
          <View style={{ height: 27 }}></View>
          <Text
            style={{ fontSize: 20, marginVertical: 20, fontWeight: 'bold' }}>
            Definitions
          </Text>
          {
            showDefinitions && definitions.map((definition, index) => (
              <View key={index}>
                <Text>{index + 1}. {definition}</Text>
              </View>
            ))
          }
        </ScrollView>
      </View>
    </View>
  );
}
