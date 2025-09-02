import "../../global.css"
import { Text, View } from "react-native";
 
export default function Settings() {
  return (
    <View className="flex-1 items-center justify-center bg-white">
      <Text className="text-xl font-bold text-blue-500">
        This is settings page.
      </Text>
    </View>
  );
}