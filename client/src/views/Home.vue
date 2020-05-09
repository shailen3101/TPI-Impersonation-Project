<template>
  <v-app id="sandbox">
    <v-navigation-drawer
      v-model="homeLayout.model"
      :clipped="homeLayout.clipped"
      app
      overflow
    ></v-navigation-drawer>

    <v-app-bar :clipped-left="homeLayout.clipped" app>
      <v-app-bar-nav-icon
        @click.stop="homeLayout.model = !homeLayout.model"
      ></v-app-bar-nav-icon>
      <v-toolbar-title>RGS Impersonation</v-toolbar-title>
    </v-app-bar>

    <v-content>
      <v-container fluid>
        <v-row align="center" justify="center">
          <v-col cols="10">
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

    <v-footer :inset="footer.inset" app>
      <span class="px-4">&copy; {{ new Date().getFullYear() }}</span>
    </v-footer>
  </v-app>
</template>

<script>
export default {
  name: "RGS Impersonation",
  data: () => ({
    drawers: ["Default (no property)", "Permanent", "Temporary"],
    homeLayout: {
      model: null,
      type: "default (no property)",
      clipped: true
    },
    footer: {
      inset: false
    }
  })
};
</script>
