import React from 'react';
import {Text as TextComponent, StyleSheet, GestureResponderEvent} from 'react-native';

type Props = {
  numberOfLines?: number,
  onPress?: (event: GestureResponderEvent) => void,
  children: string,
}

const Text = (props: Props) => {
  return (
    <TextComponent 
      style={styles.baseText} 
      numberOfLines={props.numberOfLines} 
      onPress={props.onPress} 
    > 
    {props.children}
    </TextComponent>

  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
  },
  baseText: {
    fontFamily: 'Cochin',
  },
  titleText: {
    fontSize: 20,
    fontWeight: 'bold',
  },
});

export default Text;