<template>
  <v-container fluid>
    <app-tab @changedTab="selectedTab"></app-tab>
    <component :is="selectedComponent"></component>
  </v-container>
</template>

<script>
import AppTab from "../../components/MethodContent/Tab.vue";

export default {
  props: {
    urlCommandObject: {
      type: Object
    }
  },
  components: {
    AppTab,
    "app-request": () =>
      import(
        /* webpackChunkName: "group-command" */ "../../components/MethodContent/Request.vue"
      )
  },
  data: () => ({
    currentCommand: "",
    selectedComponent: "app-request"
  }),
  methods: {
    selectedTab(tab) {
      if (tab === "request") this.selectedComponent = "app-request";
      else this.selectedComponent = "app-details";
    }
  },
  watch: {
    urlCommandObject() {
      this.currentCommand = { ...this.urlCommandObject };
      console.log(this.currentCommand);
    }
  },
  created() {
    this.currentCommand = { ...this.urlCommandObject };
    console.log(this.currentCommand);
  }
};
</script>
