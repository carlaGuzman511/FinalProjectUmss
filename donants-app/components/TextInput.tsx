import React from 'react';
import {StyleSheet, TextInput as TextInputComponent, KeyboardTypeOptions} from 'react-native';

type Props = {
  onChangeText: (text: string) => void,
  text?: string,
  placeholder?: string,
  keyboardtype?: KeyboardTypeOptions | undefined,
  autocomplete?: any,
}

const TextInput = (props: Props) => {
  return (
    <TextInputComponent
      style={styles.input}
      onChangeText={props.onChangeText}
      placeholder={props.placeholder}
      keyboardType={props.keyboardtype}
      autoComplete={props.autocomplete}
      value={props.text}
    >
    </TextInputComponent>
  );
};

const styles = StyleSheet.create({
  input: {
    height: 40,
    margin: 12,
    borderWidth: 1,
    padding: 10,
    borderRadius: 12,
    // backgroundColor: "#f0f0f0",
    // borderColor: "#ccc",
  },
});

export default TextInput;