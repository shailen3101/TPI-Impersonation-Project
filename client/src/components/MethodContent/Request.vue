<template>
  <v-row align="center" justify="center">
    <v-col cols="12">
      <v-card>
        <v-card-title class="green--text">TPI_VerifyPlayerSession Request</v-card-title>
        <v-card-subtitle class="black--text">Enter the JSON and hit send to get a Response</v-card-subtitle>
        <v-col>
          <app-form></app-form>
        </v-col>
        <v-col align="right">
          <v-btn color="blue">Send Request</v-btn>
        </v-col>
      </v-card>
    </v-col>
  </v-row>
</template>

<script>
import AppForm from "./Form.vue";

export default {
  props: {
    isSelected: Boolean
  },
  components: {
    AppForm
  }
};
</script>
