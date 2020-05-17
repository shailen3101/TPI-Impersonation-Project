<template>
  <v-form>
    <v-row>
      <v-col cols="12" md="4">
        <v-text-field label="brandId" required></v-text-field>
      </v-col>
      <v-col cols="12" md="4">
        <v-text-field label="skinId" required></v-text-field>
      </v-col>
      <v-col cols="12" md="4">
        <v-text-field label="gameId" required></v-text-field>
      </v-col>
    </v-row>
    <v-row>
      <v-col cols="12" md="4">
        <v-text-field label="channelType" required></v-text-field>
      </v-col>

      <v-col cols="12" md="4">
        <v-text-field label="presentType" required></v-text-field>
      </v-col>

      <v-col cols="12" md="4">
        <v-text-field label="secureToken" required></v-text-field>
      </v-col>
    </v-row>
    <v-row>
      <v-col cols="12" md="4">
        <v-text-field label="playerId" required></v-text-field>
      </v-col>
      <v-col cols="12" md="4">
        <v-text-field label="accountId" required></v-text-field>
      </v-col>
      <v-col cols="12" md="4">
        <v-text-field label="localeCode" required></v-text-field>
      </v-col>
    </v-row>
    <v-row>
      <v-col cols="12" md="4">
        <v-text-field label="currencyCode" required></v-text-field>
      </v-col>
      <v-col cols="12" md="4">
        <v-text-field label="includePlayerInfo" required></v-text-field>
      </v-col>
      <v-col cols="12" md="4">
        <v-text-field label="ABC_myOption" required></v-text-field>
      </v-col>
    </v-row>
  </v-form>
</template>

<script>
export default {};
</script>