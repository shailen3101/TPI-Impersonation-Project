<template>
  <v-tabs :value="tabSelected" class="d-flex justify-center mb-6">
    <v-tab @click="changedTab('details')">Details</v-tab>
    <v-tab @click="changedTab('request')">Send Request</v-tab>
  </v-tabs>
</template>

<script>
export default {
  data: () => ({
    tabSelected: 1
  }),
  methods: {
    changedTab(tab) {
      if (tab === "request") this.tabSelected = 1;
      else this.tabSelected = 0;
      this.$emit("changedTab", tab);
    }
  }
};
</script>
