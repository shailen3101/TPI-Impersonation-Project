<template>
  <v-content>
    <v-container fluid>
      <v-row align="center" justify="center">
        <v-col cols="12">
          <v-card>
            <v-card-text>
              <v-row>
                <v-col cols="12" md="6">
                  <span>Scheme</span>
                  <v-switch
                    v-model="$vuetify.theme.dark"
                    primary
                    label="Dark"
                  ></v-switch>
                </v-col>
              </v-row>
            </v-card-text>
            <v-card-actions>
              <v-spacer></v-spacer>
              <v-btn text>Cancel</v-btn>
              <v-btn text color="primary">Submit</v-btn>
            </v-card-actions>
          </v-card>
        </v-col>
      </v-row>
    </v-container>
  </v-content>
</template>

<script>
export default {};
</script>
