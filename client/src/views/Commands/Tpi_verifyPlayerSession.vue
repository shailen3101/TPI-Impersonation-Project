<template>
  <v-container fluid>
    <app-tab @changedTab="selectedTab"></app-tab>
    <component :is="selectedComponent"></component>
  </v-container>
</template>

<script>
import AppTab from "../../components/MethodContent/Tab.vue";

export default {
  components: {
    AppTab,
    "app-request": () => import("../../components/MethodContent/Request.vue") // overkill
  },
  data: () => ({
    selectedComponent: "app-request"
  }),
  methods: {
    selectedTab(tab) {
      if (tab === "request") this.selectedComponent = "app-request";
      else this.selectedComponent = "app-details";
    }
  }
};
</script>
