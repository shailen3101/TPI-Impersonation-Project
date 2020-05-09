<template>
  <div>
    <v-navigation-drawer
      v-model="homeLayout.model"
      :clipped="homeLayout.clipped"
      app
    >
      <v-list-item>
        <v-list-item-content>
          <v-list-item-title>TPI Commands</v-list-item-title>
        </v-list-item-content>
      </v-list-item>
      <v-divider></v-divider>
      <v-list dense>
        <v-list-item v-for="item in items" :key="item.title" link>
          <v-list-item-icon>
            <v-icon>{{ item.icon }}</v-icon>
          </v-list-item-icon>
          <v-list-item-content>
            <v-list-item-title>{{ item.title }}</v-list-item-title>
          </v-list-item-content>
        </v-list-item>
      </v-list>
    </v-navigation-drawer>

    <v-app-bar :clipped-left="homeLayout.clipped" app>
      <v-app-bar-nav-icon
        @click.stop="homeLayout.model = !homeLayout.model"
        class="blue--text text--lighten-2"
      >
      </v-app-bar-nav-icon>
      <v-toolbar-title cols="12" class="blue--text">
        RGS Impersonation
      </v-toolbar-title>
    </v-app-bar>
  </div>
</template>

<script>
export default {
  data: () => ({
    homeLayout: {
      model: null,
      type: "default (no property)",
      clipped: true
    }
  })
};
</script>
