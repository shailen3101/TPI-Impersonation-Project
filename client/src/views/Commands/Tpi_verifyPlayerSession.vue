<template>
  <v-container fluid>
    <app-tab @changedTab="selectedTab"></app-tab>
    <component :is="selectedComponent"></component>
  </v-container>
</template>

<script>
import AppTab from "../../components/MethodContent/Tab.vue";
import AppRequest from "../../components/MethodContent/Request.vue";

export default {
  data: () => ({
    selectedComponent: "app-request"
  }),
  components: {
    AppTab,
    "app-request": AppRequest
  },
  methods: {
    selectedTab(tab) {
      if (tab === "request") this.selectedComponent = "app-request";
      else this.selectedComponent = "app-details";
    }
  }
};
</script>
