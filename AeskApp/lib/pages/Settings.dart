import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:flutter/material.dart';

class Settings extends StatefulWidget {
  @override
  _SettingsState createState() => _SettingsState();
}

class _SettingsState extends State<Settings> {
  @override
  Widget build(BuildContext context) {
    return aeskScaffold(
      myBody: Center(
        child: Text(
          "dsagfs",
          style: Theme.of(context).textTheme.body1,
        ),
      ),
      context: context
    );
  }
}
