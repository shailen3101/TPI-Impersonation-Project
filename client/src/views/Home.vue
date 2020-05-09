<template>
  <v-app>
    <app-header />
    <AppContent />
  </v-app>
</template>

<script>
import AppHeader from "../components/shared/Header.vue";
import AppContent from "./../components/Content.vue";

export default {
  components: {
    AppHeader,
    AppContent
  }
};
</script>
