<template>
  <v-jsoneditor
    v-model="json"
    :options="{ mode: 'code' }"
    :plus="false"
    height="400px"
    @error="onError"
  />
</template>
<script>
import VJsoneditor from "v-jsoneditor/src/index";

export default {
  name: "app",
  components: {
    VJsoneditor
  },
  data() {
    return {
      json: {
        rgsId: "",
        igpId: "",
        command: "",
        requestId: "",
        data: {
          brandId: "",
          skinId: "",
          gameId: "",
          channelType: "",
          presentType: "",
          secureToken: "",
          playerId: "",
          accountId: "",
          localeCode: "",
          currencyCode: ""
        }
      }
    };
  },
  methods: {
    onError() {
      console.log("error");
    }
  }
};
</script>

