import React, {useState} from 'react';
import {StyleSheet, View} from 'react-native';
import {SafeAreaView, SafeAreaProvider} from 'react-native-safe-area-context';
import Text from '@/components/Text';
import TextInput from '@/components/TextInput';
import { BloodType } from '@/models/App.types';
import Button from './Button';
import DateInput from '@/components/DatePicker';

type Props = {

}

type fo = {
  fullName: string,
  bornDate: Date,
  bloodType: BloodType,
  address: string,
  emailAddress: string,
  phoneNumber: number,
}

const form = (props: Props) => {
  const [fullName, setFullName] = useState("");
  const [phoneNumber, setPhoneNumber] = useState("");
  const [bornDate, setBornDate] = useState("");
  const [bloodType, setBloodType] = useState("");
  const [address, setAddress] = useState("");
  const [emailAddress, setEmailAddress] = useState("");

  const onFullNameChanged = (text: string) => {
    setFullName(text);
  }
  const onPhoneNumberChanged = (text: string) => {
    setPhoneNumber(text);
  }  
  const onBornDateChanged = (text: string) => {
    setBornDate(text);
  }  
  const onBloodTypeChanged = (text: string) => {
    setBloodType(text);
  }  
  const onAddressChanged = (text: string) => {
    setAddress(text);
  }  
  const onEmailAddressChanged = (text: string) => {
    setEmailAddress(text);
  }
  const onSubmit = () => {

  }
  return (
    <View style={styles.container}>
      <SafeAreaProvider>
        <SafeAreaView>
          <Text>Nombres y Apellidos</Text>
          <TextInput text={fullName} onChangeText={onFullNameChanged}></TextInput>
          <Text>Fecha de Nacimiento</Text>
          <DateInput></DateInput>
          <TextInput text={bornDate} onChangeText={onBornDateChanged} autocomplete='birthdate-full' />
          <Text>Tipo de Sangre</Text>
          <TextInput text={bloodType} onChangeText={onBloodTypeChanged}/>
          <Text>Numero de Telefono</Text>
          <TextInput text={phoneNumber} onChangeText={onPhoneNumberChanged}/>
          <Text>Correo Electronico</Text>
          <TextInput text={emailAddress} onChangeText={onEmailAddressChanged} autocomplete='email' />
          <Text>Direccion</Text>
          <TextInput text={address} onChangeText={onAddressChanged}/>
          <Button label='Guardar' theme='primary' onPress={onSubmit}/>
        </SafeAreaView>
      </SafeAreaProvider>
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    // height: 20,
    width: 350,
  },
});

export default form;