<template>
  <v-container fluid>
    <v-row align="center" justify="center">
      <v-col cols="12">
        <v-card>
          <v-card-title class="green--text">TPI_VerifyPlayerSession Request</v-card-title>
          <v-card-subtitle class="black--text">Enter the JSON and hit send to get a Response</v-card-subtitle>
          <json-editor style="padding: 10px"></json-editor>
          <v-col align="right">
            <v-btn color="blue">Send Request</v-btn>
          </v-col>
        </v-card>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
import JsonEditor from "./RequestForm/JsonEditor.vue";

export default {
  components: {
    JsonEditor
  },
  data: () => {
    return {};
  },
  methods: {
    onError() {
      console.log("error");
    }
  }
};
</script>
