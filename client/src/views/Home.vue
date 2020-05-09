<template>
  <v-app>
    <app-header />
    <app-content />
    <app-footer />
  </v-app>
</template>

<script>
import AppHeader from "../components/shared/Header.vue";
import AppContent from "./../components/Content.vue";
import AppFooter from "./../components/shared/Footer.vue";

export default {
  components: {
    AppHeader,
    AppContent,
    AppFooter
  }
};
</script>
