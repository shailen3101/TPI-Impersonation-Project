<template>
  <v-container fluid>
    <v-row align="center" justify="center">
      <v-col cols="12">
        <v-card>
          <v-card-title class="green--text">
            Make a TPI_VerifyPlayerSession Request
          </v-card-title>
          <v-card-text class="black--text"> </v-card-text>
        </v-card>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
export default {
  data: () => {
    return {
      json: {}
    };
  },
  components: {},
  methods: {
    onError() {
      console.log("error");
    }
  }
};
</script>
