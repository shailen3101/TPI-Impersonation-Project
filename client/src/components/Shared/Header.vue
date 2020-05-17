<template>
	<div>
		<v-navigation-drawer
			v-model="homeLayout.model"
			:clipped="homeLayout.clipped"
			app
		>
			<v-list-item>
				<v-list-item-content>
					<v-list-item-title class="title blue--text">
						TPI Commands
					</v-list-item-title>
				</v-list-item-content>
			</v-list-item>
			<v-divider></v-divider>
			<v-list nav>
				<v-list-item-group v-model="name" color="primary">
					<v-list-item
						v-for="name in commandNames"
						:key="name"
						@click="navigateTo(name)"
						link
					>
						<v-list-item-content>
							<v-list-item-title> {{ name }}</v-list-item-title>
						</v-list-item-content>
					</v-list-item>
				</v-list-item-group>
			</v-list>
		</v-navigation-drawer>

		<v-app-bar :clipped-left="homeLayout.clipped" app>
			<v-app-bar-nav-icon
				@click.stop="homeLayout.model = !homeLayout.model"
				class="blue--text text--lighten-2"
			></v-app-bar-nav-icon>

			<v-toolbar-title cols="12" class="blue--text">
				<router-link to="/" style="text-decoration: none">
					RGS Impersonation
				</router-link>
			</v-toolbar-title>
		</v-app-bar>
	</div>
</template>

<script>
	import { commandNames } from '../../util/data.js'

	export default {
		data: () => ({
			name: '', // Used to keep track of what is select in the navbar
			commandNames: commandNames,
			homeLayout: {
				model: null,
				type: 'default (no property)',
				clipped: true,
			},
		}),
		methods: {
			navigateTo(link) {
				//Checks the route path and if equal doesn't route to that location.
				const path = `/command/${link}`
				if (this.$route.path !== path) this.$router.push(`/command/${link}`)
			},
		},
		created() {
			this.$vuetify.theme.dark = true
		},
	}
</script>
