import { StyleSheet, Text, View } from 'react-native';
import { Image, type ImageSource } from 'expo-image';
import { Post, DonationType, Status, PostType } from '@/models/App.types';

type Props = {
  item: Post;
};

export default function CardViewer({ item }: Props) {
 return ( 
    <View>
      <View>
        <Text style={styles.title}>{item.title}</Text>
        <Text style={styles.status}>{Status[item.statusId]}</Text>
      </View>
      <Text style={styles.description}>{item.description.replace(/\\n/g, '\n')}</Text>
      
      <Text>{item.postDate}</Text>
      {item.postTypeId === PostType.Donacion ? (<Text>{DonationType[item.donationTypeId]}</Text>) : (<></>)}   

      <Image source={item.image} style={styles.image} />  
    </View>
  );
}

const styles = StyleSheet.create({
  image: {
    width: 320,
    height: 440,
    borderRadius: 18,
  },
  title: {
    fontSize: 16,
    fontWeight: 'bold',
    marginBottom: 16,
    backgroundColor: '#fff'
  },
  description: {
    fontSize: 14,
    marginBottom: 16,
    backgroundColor: '#fff'
  },
  status: {
    backgroundColor: '#f5f5f5',
    // padding: 10,
    borderRadius: 8,
  },
});
