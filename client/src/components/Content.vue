<template>
  <v-content>
    <div :is="(VerifyPlayerSession = 'VerifyPlayerSession')"></div>
  </v-content>
</template>

<script>
import VerifyPlayerSession from "./Methods/VerifyPlayerSession.vue";

export default {
  components: {
    VerifyPlayerSession
  }
};
</script>
