import React, { useState } from "react";
import { View, Button, TextInput } from "react-native";
import DatePicker from "react-native-date-picker";

const DateInput = () => {
  const [date, setDate] = useState(new Date());
  const [open, setOpen] = useState(false);
  const [editable, setEditable] = useState(false);

  return (
    <View style={{ padding: 20 }}>
      <TextInput
        value={date.toDateString()} 
        editable={false} 
        onPress={() => {
          setOpen(true);
          setEditable(true);
        }}
        style={{
          borderWidth: 1, 
          padding: 10, 
          borderRadius: 5 
        }}
      />
      <DatePicker
        modal
        open={open}
        date={date}
        onConfirm={(selectedDate) => {
          setOpen(false);
          setDate(selectedDate);
        }}
        onCancel={() => setOpen(false)}
      />
    </View>
  );
};

export default DateInput;
