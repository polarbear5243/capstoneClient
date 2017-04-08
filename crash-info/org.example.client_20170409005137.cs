S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 6971
Date: 2017-04-09 00:51:37+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 6971, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb6e6c374
r2   = 0x0000005f, r3   = 0x00000065
r4   = 0xb8fcf8d8, r5   = 0xb6e6c374
r6   = 0xb8eeb8e0, r7   = 0xb913c210
r8   = 0x00000000, r9   = 0xb8e097f8
r10  = 0xb6ed2eac, fp   = 0x00000000
ip   = 0xb5f671d8, sp   = 0xbefc3ea0
lr   = 0xb5f526cd, pc   = 0xb67786f0
cpsr = 0xa0070030

Memory Information
MemTotal:   987012 KB
MemFree:    141044 KB
Buffers:     44208 KB
Cached:     335552 KB
VmPeak:     141196 KB
VmSize:     139940 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       35728 KB
VmRSS:       34792 KB
VmData:      51928 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35796 KB
VmPTE:         106 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 6971 TID = 6971
6971 6972 6994 6995 7012 

Maps Information
af22e000 afa2d000 rw-p [stack:7012]
b0ff0000 b1001000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1011000 b1016000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1418000 b1420000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1432000 b1c31000 rw-p [stack:6995]
b1c31000 b1c32000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1c42000 b1c56000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c6a000 b1c6b000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c7b000 b1c7e000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c8f000 b1c90000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1ca0000 b1ca2000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1cb2000 b1cb4000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1cc4000 b1cd4000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1ce4000 b1cf0000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1d02000 b2501000 rw-p [stack:6994]
b2832000 b2839000 r-xp /usr/lib/libefl-extension.so.0.1.0
b284c000 b2852000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2862000 b2882000 r-xp /opt/usr/apps/org.example.client/bin/client
b29cb000 b2aae000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2ae5000 b2b0d000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2b1f000 b331e000 rw-p [stack:6972]
b331e000 b3320000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3330000 b333a000 r-xp /lib/libnss_files-2.20-2014.11.so
b334b000 b3354000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3365000 b3376000 r-xp /lib/libnsl-2.20-2014.11.so
b3389000 b338f000 r-xp /lib/libnss_compat-2.20-2014.11.so
b33a0000 b33a1000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b33c9000 b33d0000 r-xp /usr/lib/libminizip.so.1.0.0
b33e0000 b33e5000 r-xp /usr/lib/libstorage.so.0.1
b33f5000 b3454000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b346a000 b347e000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b348e000 b34d2000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34e2000 b34ea000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34fa000 b352a000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b353d000 b35f6000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b360a000 b365d000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b366e000 b3689000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3699000 b375a000 r-xp /usr/lib/libprotobuf.so.9.0.1
b376d000 b377d000 r-xp /usr/lib/libefl-assist.so.0.1.0
b378d000 b379a000 r-xp /usr/lib/libmdm-common.so.1.0.98
b37ab000 b37b2000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b37c2000 b3803000 r-xp /usr/lib/libmdm.so.1.2.12
b3813000 b381b000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b382a000 b383a000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b385b000 b38bb000 r-xp /usr/lib/libasound.so.2.0.0
b38cd000 b38d0000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38e0000 b38e3000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38f3000 b38f8000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3908000 b3909000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3919000 b3924000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3938000 b393f000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b394f000 b3955000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3965000 b396a000 r-xp /usr/lib/libmmfsession.so.0.0.1
b397a000 b3995000 r-xp /usr/lib/libmmfsound.so.0.1.0
b39a5000 b39ac000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b39bc000 b39bf000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b39d0000 b39fe000 r-xp /usr/lib/libidn.so.11.5.44
b3a0e000 b3a24000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3a35000 b3a3f000 r-xp /usr/lib/libcares.so.2.1.0
b3a4f000 b3a59000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a69000 b3a6b000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a7b000 b3a7c000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a8c000 b3a90000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3aa1000 b3ac9000 r-xp /usr/lib/libui-extension.so.0.1.0
b3ada000 b3b03000 r-xp /usr/lib/libturbojpeg.so
b3b23000 b3b29000 r-xp /usr/lib/libgif.so.4.1.6
b3b39000 b3b7f000 r-xp /usr/lib/libcurl.so.4.3.0
b3b90000 b3bb1000 r-xp /usr/lib/libexif.so.12.3.3
b3bcc000 b3be1000 r-xp /usr/lib/libtts.so
b3bf2000 b3bfa000 r-xp /usr/lib/libfeedback.so.0.1.4
b3c0a000 b3cd0000 r-xp /usr/lib/libdali-core.so.0.0.0
b3cf0000 b3de8000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3e07000 b3ed5000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3eec000 b3eee000 r-xp /usr/lib/libboost_system.so.1.51.0
b3efe000 b3f04000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3f14000 b3f37000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f48000 b3f4a000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f5a000 b3f5c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f6d000 b3f72000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f89000 b3f8b000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f9b000 b3fa2000 r-xp /usr/lib/libsensord-share.so
b3fb2000 b3fca000 r-xp /usr/lib/libsensor.so.1.1.0
b3fdb000 b3fde000 r-xp /usr/lib/libXv.so.1.0.0
b3fee000 b3ff3000 r-xp /usr/lib/libutilX.so.1.1.0
b4003000 b4008000 r-xp /usr/lib/libappcore-common.so.1.1
b4018000 b401f000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b4032000 b4036000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4047000 b4125000 r-xp /usr/lib/libCOREGL.so.4.0
b4145000 b4148000 r-xp /usr/lib/libuuid.so.1.3.0
b4158000 b416f000 r-xp /usr/lib/libblkid.so.1.1.0
b4180000 b4182000 r-xp /usr/lib/libXau.so.6.0.0
b4192000 b41d9000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41eb000 b41f1000 r-xp /usr/lib/libjson-c.so.2.0.1
b4202000 b4206000 r-xp /usr/lib/libogg.so.0.7.1
b4216000 b4238000 r-xp /usr/lib/libvorbis.so.0.4.3
b4248000 b432c000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4348000 b434b000 r-xp /usr/lib/libEGL.so.1.4
b435c000 b4362000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4372000 b4374000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4384000 b4391000 r-xp /usr/lib/libGLESv2.so.2.0
b43a2000 b4404000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4419000 b4431000 r-xp /usr/lib/libmount.so.1.1.0
b4443000 b4457000 r-xp /usr/lib/libxcb.so.1.1.0
b4467000 b446e000 r-xp /lib/libcrypt-2.20-2014.11.so
b44a6000 b44a8000 r-xp /usr/lib/libiri.so
b44b8000 b44c3000 r-xp /usr/lib/libgpg-error.so.0.15.0
b44d4000 b450a000 r-xp /usr/lib/libpulse.so.0.16.2
b451b000 b455e000 r-xp /usr/lib/libsndfile.so.1.0.25
b4573000 b4588000 r-xp /lib/libexpat.so.1.5.2
b459a000 b4658000 r-xp /usr/lib/libcairo.so.2.11200.14
b466c000 b4674000 r-xp /usr/lib/libdrm.so.2.4.0
b4684000 b4687000 r-xp /usr/lib/libdri2.so.0.0.0
b4697000 b46e5000 r-xp /usr/lib/libssl.so.1.0.0
b46fa000 b4706000 r-xp /usr/lib/libeeze.so.1.13.0
b4717000 b4720000 r-xp /usr/lib/libethumb.so.1.13.0
b4730000 b4733000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4743000 b48fa000 r-xp /usr/lib/libcrypto.so.1.0.0
b56e5000 b56ee000 r-xp /usr/lib/libXi.so.6.1.0
b56fe000 b5700000 r-xp /usr/lib/libXgesture.so.7.0.0
b5710000 b5714000 r-xp /usr/lib/libXtst.so.6.1.0
b5724000 b572a000 r-xp /usr/lib/libXrender.so.1.3.0
b573a000 b5740000 r-xp /usr/lib/libXrandr.so.2.2.0
b5750000 b5752000 r-xp /usr/lib/libXinerama.so.1.0.0
b5763000 b5766000 r-xp /usr/lib/libXfixes.so.3.1.0
b5776000 b5781000 r-xp /usr/lib/libXext.so.6.4.0
b5791000 b5793000 r-xp /usr/lib/libXdamage.so.1.1.0
b57a3000 b57a5000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57b5000 b5897000 r-xp /usr/lib/libX11.so.6.3.0
b58ab000 b58b2000 r-xp /usr/lib/libXcursor.so.1.0.2
b58c2000 b58da000 r-xp /usr/lib/libudev.so.1.6.0
b58dc000 b58df000 r-xp /lib/libattr.so.1.1.0
b58ef000 b590f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5910000 b5915000 r-xp /usr/lib/libffi.so.6.0.2
b5926000 b593e000 r-xp /lib/libz.so.1.2.8
b594e000 b5950000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5960000 b5a35000 r-xp /usr/lib/libxml2.so.2.9.2
b5a4a000 b5ae5000 r-xp /usr/lib/libstdc++.so.6.0.20
b5b01000 b5b04000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b14000 b5b2d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b3e000 b5b4f000 r-xp /lib/libresolv-2.20-2014.11.so
b5b63000 b5bdd000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bf2000 b5bf4000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5c04000 b5c0b000 r-xp /usr/lib/libembryo.so.1.13.0
b5c1b000 b5c25000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5c36000 b5c4e000 r-xp /usr/lib/libpng12.so.0.50.0
b5c5f000 b5c82000 r-xp /usr/lib/libjpeg.so.8.0.2
b5ca3000 b5cb7000 r-xp /usr/lib/libector.so.1.13.0
b5cc8000 b5ce0000 r-xp /usr/lib/liblua-5.1.so
b5cf1000 b5d48000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d5c000 b5d84000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d95000 b5da8000 r-xp /usr/lib/libfribidi.so.0.3.1
b5db9000 b5df3000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5e04000 b5e12000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e22000 b5e2a000 r-xp /usr/lib/libtbm.so.1.0.0
b5e3a000 b5e47000 r-xp /usr/lib/libeio.so.1.13.0
b5e57000 b5e59000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e69000 b5e6e000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e7e000 b5e95000 r-xp /usr/lib/libefreet.so.1.13.0
b5ea7000 b5ec7000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ed7000 b5ef7000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ef9000 b5eff000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5f0f000 b5f20000 r-xp /usr/lib/libemotion.so.1.13.0
b5f31000 b5f38000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f48000 b5f57000 r-xp /usr/lib/libeo.so.1.13.0
b5f68000 b5f7a000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f8b000 b5f90000 r-xp /usr/lib/libecore_file.so.1.13.0
b5fa0000 b5fb9000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fc9000 b5fe6000 r-xp /usr/lib/libeet.so.1.13.0
b5fff000 b6047000 r-xp /usr/lib/libeina.so.1.13.0
b6058000 b6068000 r-xp /usr/lib/libefl.so.1.13.0
b6079000 b615e000 r-xp /usr/lib/libicuuc.so.51.1
b617b000 b62bb000 r-xp /usr/lib/libicui18n.so.51.1
b62d2000 b630a000 r-xp /usr/lib/libecore_x.so.1.13.0
b631c000 b631f000 r-xp /lib/libcap.so.2.21
b632f000 b6358000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6369000 b6370000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6382000 b63b9000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63ca000 b64b5000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64c8000 b6541000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6553000 b6558000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6568000 b6572000 r-xp /usr/lib/libvconf.so.0.2.45
b6582000 b6584000 r-xp /usr/lib/libvasum.so.0.3.1
b6594000 b6596000 r-xp /usr/lib/libttrace.so.1.1
b65a6000 b65a9000 r-xp /usr/lib/libiniparser.so.0
b65b9000 b65df000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65ef000 b65f4000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6605000 b661c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b662d000 b6698000 r-xp /lib/libm-2.20-2014.11.so
b66a9000 b66af000 r-xp /lib/librt-2.20-2014.11.so
b66c0000 b66cd000 r-xp /usr/lib/libunwind.so.8.0.1
b6703000 b6827000 r-xp /lib/libc-2.20-2014.11.so
b683c000 b6855000 r-xp /lib/libgcc_s-4.9.so.1
b6865000 b6947000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6958000 b6982000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6993000 b69cf000 r-xp /usr/lib/libsystemd.so.0.4.0
b69d1000 b6a54000 r-xp /usr/lib/libedje.so.1.13.0
b6a67000 b6a85000 r-xp /usr/lib/libecore.so.1.13.0
b6aa5000 b6c2c000 r-xp /usr/lib/libevas.so.1.13.0
b6c61000 b6c75000 r-xp /lib/libpthread-2.20-2014.11.so
b6c89000 b6ebd000 r-xp /usr/lib/libelementary.so.1.13.0
b6eec000 b6ef0000 r-xp /usr/lib/libsmack.so.1.0.0
b6f00000 b6f07000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f17000 b6f19000 r-xp /usr/lib/libdlog.so.0.0.0
b6f29000 b6f2c000 r-xp /usr/lib/libbundle.so.0.1.22
b6f3c000 b6f3e000 r-xp /lib/libdl-2.20-2014.11.so
b6f4f000 b6f67000 r-xp /usr/lib/libaul.so.0.1.0
b6f7b000 b6f80000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f91000 b6f9e000 r-xp /usr/lib/liblptcp.so
b6fb0000 b6fb4000 r-xp /usr/lib/libsys-assert.so
b6fc5000 b6fe5000 r-xp /lib/ld-2.20-2014.11.so
b6ff6000 b6ffb000 r-xp /usr/bin/launchpad-loader
b8c49000 b95e4000 rw-p [heap]
befa4000 befc5000 rw-p [stack]
befa4000 befc5000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6971)
Call Stack Count: 1
 0: (0xb67786f0) [/lib/libc.so.6] + 0x756f0
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
 682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-09 00:50:35.613+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7772805
04-09 00:50:35.703+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7772893
04-09 00:50:35.703+0900 W/AUL     (  868): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-09 00:50:35.703+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 1
04-09 00:50:35.703+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 868
04-09 00:50:35.713+0900 E/RESOURCED(  684): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-09 00:50:35.713+0900 E/RESOURCED(  684): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-09 00:50:35.723+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
04-09 00:50:35.723+0900 W/AUL_PAD ( 1481): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-09 00:50:35.723+0900 W/AUL_PAD ( 1481): launchpad.c: __send_result_to_caller(267) > Check app launching
04-09 00:50:35.733+0900 I/abc     ( 6842): abc
04-09 00:50:35.733+0900 I/CAPI_APPFW_APPLICATION( 6842): app_main.c: ui_app_main(789) > app_efl_main
04-09 00:50:35.733+0900 I/CAPI_APPFW_APPLICATION( 6842): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-09 00:50:35.763+0900 E/TBM     ( 6842): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-09 00:50:35.823+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 6842, appid: org.example.client
04-09 00:50:35.823+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-09 00:50:35.833+0900 W/AUL     (  868): launch.c: app_request_to_launchpad(425) > request cmd(1) result(6842)
04-09 00:50:36.014+0900 D/basicui ( 6842): successed to load edc file
04-09 00:50:36.054+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:50:36.054+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:50:36.064+0900 I/Tizen::System( 1246): (259) > Active app [org.exampl], current [com.samsun] 
04-09 00:50:36.064+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:50:36.074+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:50:36.084+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-09 00:50:36.104+0900 I/MY_LOG  ( 6842): change
04-09 00:50:36.154+0900 I/APP_CORE( 6842): appcore-efl.c: __do_app(514) > [APP 6842] Event: RESET State: CREATED
04-09 00:50:36.154+0900 I/CAPI_APPFW_APPLICATION( 6842): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-09 00:50:36.164+0900 E/EFL     ( 6842): edje<6842> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:50:36.164+0900 E/EFL     ( 6842): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:50:36.164+0900 E/EFL     ( 6842): edje<6842> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:50:36.164+0900 E/EFL     ( 6842): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:50:36.174+0900 E/EFL     ( 6842): edje<6842> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:50:36.174+0900 E/EFL     ( 6842): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:50:36.174+0900 W/APP_CORE( 6842): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6c00002
04-09 00:50:36.174+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
04-09 00:50:36.304+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: PAUSE State: RUNNING
04-09 00:50:36.304+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-09 00:50:36.304+0900 E/cluster-home(  868): homescreen.cpp: OnPause(260) >  app pause
04-09 00:50:36.304+0900 I/APP_CORE( 6842): appcore-efl.c: __do_app(514) > [APP 6842] Event: RESUME State: CREATED
04-09 00:50:36.304+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(4)
04-09 00:50:36.304+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(868)
04-09 00:50:36.304+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: bg
04-09 00:50:36.304+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(6842) status(3)
04-09 00:50:36.314+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(6842)
04-09 00:50:36.314+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 6842, appid: org.example.client, status: fg
04-09 00:50:36.324+0900 I/APP_CORE( 6842): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-09 00:50:36.324+0900 I/APP_CORE( 6842): appcore-efl.c: __do_app(625) > [APP 6842] Initial Launching, call the resume_cb
04-09 00:50:36.324+0900 I/CAPI_APPFW_APPLICATION( 6842): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-09 00:50:36.324+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-09 00:50:36.324+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-09 00:50:36.324+0900 W/AUL     ( 1410): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1410, appid: com.samsung.weather-m-widget, status: bg
04-09 00:50:36.664+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(6842) status(0)
04-09 00:50:36.864+0900 I/Tizen::App( 1246): (499) > LaunchedApp(org.example.client)
04-09 00:50:36.864+0900 I/Tizen::App( 1246): (733) > Finished invoking application event listener for org.example.client, 6842.
04-09 00:50:36.875+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.570
04-09 00:50:37.635+0900 I/UXT     ( 6904): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-09 00:50:38.016+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7775199
04-09 00:50:38.096+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7775287
04-09 00:50:39.087+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7776272
04-09 00:50:39.177+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7776371
04-09 00:50:39.227+0900 D/basicui ( 6842): successed to load edc file
04-09 00:50:39.257+0900 I/MY_LOG  ( 6842): change
04-09 00:50:39.257+0900 I/MY_LOG  ( 6842): change
04-09 00:50:39.277+0900 E/VCONF   ( 6842): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-09 00:50:39.277+0900 E/VCONF   ( 6842): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-09 00:50:39.277+0900 E/VCONF   ( 6842): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-09 00:50:39.277+0900 E/VCONF   ( 6842): vconf.c: vconf_get_bool(2729) > vconf_get_bool(6842) : db/ise/keysound error
04-09 00:50:39.277+0900 E/VCONF   ( 6842): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-09 00:50:39.277+0900 E/VCONF   ( 6842): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-09 00:50:39.317+0900 I/MY_LOG  ( 6842): change
04-09 00:50:40.208+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7777402
04-09 00:50:40.208+0900 I/MY_LOG  ( 6842): Button pressed
04-09 00:50:40.278+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7777468
04-09 00:50:40.278+0900 I/MY_LOG  ( 6842): Button unpressed
04-09 00:50:40.358+0900 E/EFL     ( 6842): elementary<6842> elc_naviframe.c:1715 _tizen_pop_effect() [DDO]
04-09 00:50:41.309+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: MEM_FLUSH State: PAUSED
04-09 00:50:43.371+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7780559
04-09 00:50:43.951+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7781146
04-09 00:50:48.326+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7785508
04-09 00:50:48.326+0900 I/MY_LOG  ( 6842): Button pressed
04-09 00:50:48.406+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7785596
04-09 00:50:48.406+0900 I/MY_LOG  ( 6842): Button unpressed
04-09 00:50:48.496+0900 D/basicui ( 6842): successed to load edc file
04-09 00:50:48.506+0900 I/MY_LOG  ( 6842): change
04-09 00:50:50.117+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7787302
04-09 00:50:50.428+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7787612
04-09 00:50:52.159+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7789334
04-09 00:50:52.219+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7789411
04-09 00:50:53.411+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7790605
04-09 00:50:53.491+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7790682
04-09 00:50:54.221+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7791411
04-09 00:50:54.302+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7791488
04-09 00:50:54.952+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7792142
04-09 00:50:55.353+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7792540
04-09 00:50:56.023+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7793209
04-09 00:50:56.364+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7793529
04-09 00:50:57.074+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7794254
04-09 00:50:57.144+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7794331
04-09 00:50:58.035+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7795222
04-09 00:50:58.125+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7795310
04-09 00:50:59.587+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7796777
04-09 00:50:59.587+0900 I/MY_LOG  ( 6842): Button pressed
04-09 00:50:59.667+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7796854
04-09 00:50:59.667+0900 I/MY_LOG  ( 6842): Button unpressed
04-09 00:50:59.687+0900 E/EFL     ( 6842): elementary<6842> elc_naviframe.c:1715 _tizen_pop_effect() [DDO]
04-09 00:50:59.997+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(195) > ""
04-09 00:51:00.007+0900 E/UXT     (  682): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 12:51
04-09 00:51:00.007+0900 I/INDICATOR(  682): clock.c: getTimeFormatted(176) > "time format : 오전 12:51"
04-09 00:51:00.007+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 12:51"
04-09 00:51:00.007+0900 W/INDICATOR(  682): clock.c: indicator_clock_changed_cb(272) > 
04-09 00:51:00.007+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145476264 Time: <font_size=31> </font_size> <font_size=31> 오전 12:51</font_size></font>"
04-09 00:51:01.338+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7798530
04-09 00:51:01.438+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7798629
04-09 00:51:01.489+0900 D/basicui ( 6842): successed to load edc file
04-09 00:51:01.509+0900 I/MY_LOG  ( 6842): change
04-09 00:51:01.509+0900 I/MY_LOG  ( 6842): change
04-09 00:51:01.529+0900 I/MY_LOG  ( 6842): change
04-09 00:51:02.510+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7799705
04-09 00:51:02.510+0900 I/MY_LOG  ( 6842): Button pressed
04-09 00:51:02.600+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7799792
04-09 00:51:02.600+0900 I/MY_LOG  ( 6842): Button unpressed
04-09 00:51:02.680+0900 E/EFL     ( 6842): elementary<6842> elc_naviframe.c:1715 _tizen_pop_effect() [DDO]
04-09 00:51:03.641+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7800837
04-09 00:51:03.751+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7800947
04-09 00:51:03.991+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:51:04.011+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(3)
04-09 00:51:04.011+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-09 00:51:04.011+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-09 00:51:04.011+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(868)
04-09 00:51:04.011+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: fg
04-09 00:51:04.021+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(0)
04-09 00:51:04.031+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 6842 pgid = 6842
04-09 00:51:04.031+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(143) > dead_pid(6842)
04-09 00:51:04.061+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: RESUME State: PAUSED
04-09 00:51:04.061+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:51:04.061+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-09 00:51:04.061+0900 E/cluster-home(  868): homescreen.cpp: OnResume(233) >  app resume
04-09 00:51:04.071+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-09 00:51:04.071+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-09 00:51:04.071+0900 E/AUL_PAD ( 1481): launchpad.c: main(698) > error reading sigchld info
04-09 00:51:04.071+0900 I/Tizen::App( 1246): (243) > App[org.example.client] pid[6842] terminate event is forwarded
04-09 00:51:04.071+0900 I/Tizen::System( 1246): (256) > osp.accessorymanager.service provider is found.
04-09 00:51:04.071+0900 I/Tizen::System( 1246): (196) > Accessory Owner is removed [org.example.client, 6842, ]
04-09 00:51:04.071+0900 I/Tizen::System( 1246): (256) > osp.system.service provider is found.
04-09 00:51:04.071+0900 I/Tizen::App( 1246): (506) > TerminatedApp(org.example.client)
04-09 00:51:04.071+0900 I/Tizen::App( 1246): (512) > Not registered pid(6842)
04-09 00:51:04.071+0900 I/Tizen::System( 1246): (246) > Terminated app [org.example.client]
04-09 00:51:04.071+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:51:04.071+0900 I/ESD     (  919): esd_main.c: __esd_app_dead_handler(1773) > pid: 6842
04-09 00:51:04.071+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 6842
04-09 00:51:04.071+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 6842
04-09 00:51:04.081+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.574
04-09 00:51:04.091+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:51:04.091+0900 I/Tizen::App( 1246): (782) > Finished invoking application event listener for org.example.client, 6842.
04-09 00:51:04.101+0900 E/weather-widget( 1410): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-09 00:51:04.101+0900 I/Tizen::System( 1246): (259) > Active app [com.samsun], current [org.exampl] 
04-09 00:51:04.111+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:51:04.141+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-09 00:51:04.141+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-09 00:51:04.141+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-09 00:51:04.141+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-09 00:51:04.151+0900 E/weather-widget( 1410): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-09 00:51:04.151+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-09 00:51:04.171+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7801362
04-09 00:51:04.181+0900 E/weather-common( 1410): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-09 00:51:04.181+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:51:04.181+0900 W/CRASH_MANAGER( 6913): worker.c: worker_job(1199) > 1106842636c691491666663
04-09 00:51:04.261+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7801448
04-09 00:51:04.281+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_create(409) > New handle created[0xb8430a10]
04-09 00:51:04.281+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_get_type(463) > Connected Network = 2
04-09 00:51:04.281+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_destroy(427) > Destroy handle: 0xb8430a10
04-09 00:51:04.281+0900 E/weather-common( 1410): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-09 00:51:04.281+0900 E/weather-widget( 1410): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-09 00:51:04.281+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-09 00:51:04.281+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-09 00:51:04.281+0900 W/AUL     ( 1410): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1410, appid: com.samsung.weather-m-widget, status: fg
04-09 00:51:16.133+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7813318
04-09 00:51:16.173+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7813362
04-09 00:51:16.173+0900 W/AUL     (  868): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-09 00:51:16.173+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 1
04-09 00:51:16.183+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 868
04-09 00:51:16.193+0900 E/RESOURCED(  684): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-09 00:51:16.193+0900 E/RESOURCED(  684): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-09 00:51:16.193+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
04-09 00:51:16.193+0900 W/AUL_PAD ( 1481): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-09 00:51:16.193+0900 W/AUL_PAD ( 1481): launchpad.c: __send_result_to_caller(267) > Check app launching
04-09 00:51:16.203+0900 I/abc     ( 6904): abc
04-09 00:51:16.203+0900 I/CAPI_APPFW_APPLICATION( 6904): app_main.c: ui_app_main(789) > app_efl_main
04-09 00:51:16.203+0900 I/CAPI_APPFW_APPLICATION( 6904): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-09 00:51:16.233+0900 E/TBM     ( 6904): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-09 00:51:16.293+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 6904, appid: org.example.client
04-09 00:51:16.293+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-09 00:51:16.293+0900 W/AUL     (  868): launch.c: app_request_to_launchpad(425) > request cmd(1) result(6904)
04-09 00:51:16.493+0900 D/basicui ( 6904): successed to load edc file
04-09 00:51:16.523+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:51:16.523+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:51:16.533+0900 I/Tizen::System( 1246): (259) > Active app [org.exampl], current [com.samsun] 
04-09 00:51:16.533+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:51:16.543+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:51:16.553+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-09 00:51:16.573+0900 I/MY_LOG  ( 6904): change
04-09 00:51:16.623+0900 I/APP_CORE( 6904): appcore-efl.c: __do_app(514) > [APP 6904] Event: RESET State: CREATED
04-09 00:51:16.623+0900 I/CAPI_APPFW_APPLICATION( 6904): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-09 00:51:16.633+0900 E/EFL     ( 6904): edje<6904> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:51:16.633+0900 E/EFL     ( 6904): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:51:16.633+0900 E/EFL     ( 6904): edje<6904> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:51:16.633+0900 E/EFL     ( 6904): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:51:16.643+0900 E/EFL     ( 6904): edje<6904> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:51:16.643+0900 E/EFL     ( 6904): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:51:16.643+0900 W/APP_CORE( 6904): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6400002
04-09 00:51:16.643+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
04-09 00:51:16.773+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: PAUSE State: RUNNING
04-09 00:51:16.773+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-09 00:51:16.773+0900 I/APP_CORE( 6904): appcore-efl.c: __do_app(514) > [APP 6904] Event: RESUME State: CREATED
04-09 00:51:16.773+0900 E/cluster-home(  868): homescreen.cpp: OnPause(260) >  app pause
04-09 00:51:16.773+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(4)
04-09 00:51:16.773+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(868)
04-09 00:51:16.773+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: bg
04-09 00:51:16.783+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(6904) status(3)
04-09 00:51:16.783+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(6904)
04-09 00:51:16.783+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 6904, appid: org.example.client, status: fg
04-09 00:51:16.793+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-09 00:51:16.793+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-09 00:51:16.793+0900 W/AUL     ( 1410): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1410, appid: com.samsung.weather-m-widget, status: bg
04-09 00:51:16.803+0900 I/APP_CORE( 6904): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-09 00:51:16.803+0900 I/APP_CORE( 6904): appcore-efl.c: __do_app(625) > [APP 6904] Initial Launching, call the resume_cb
04-09 00:51:16.803+0900 I/CAPI_APPFW_APPLICATION( 6904): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-09 00:51:17.134+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(6904) status(0)
04-09 00:51:17.334+0900 I/Tizen::App( 1246): (499) > LaunchedApp(org.example.client)
04-09 00:51:17.334+0900 I/Tizen::App( 1246): (733) > Finished invoking application event listener for org.example.client, 6904.
04-09 00:51:17.344+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.577
04-09 00:51:18.115+0900 I/UXT     ( 6971): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-09 00:51:19.026+0900 E/EFL     ( 6904): ecore_x<6904> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7816209
04-09 00:51:19.096+0900 E/EFL     ( 6904): ecore_x<6904> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7816286
04-09 00:51:19.146+0900 D/basicui ( 6904): successed to load edc file
04-09 00:51:19.166+0900 I/MY_LOG  ( 6904): change
04-09 00:51:19.176+0900 I/MY_LOG  ( 6904): change
04-09 00:51:19.196+0900 E/VCONF   ( 6904): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-09 00:51:19.196+0900 E/VCONF   ( 6904): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-09 00:51:19.196+0900 E/VCONF   ( 6904): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-09 00:51:19.196+0900 E/VCONF   ( 6904): vconf.c: vconf_get_bool(2729) > vconf_get_bool(6904) : db/ise/keysound error
04-09 00:51:19.196+0900 E/VCONF   ( 6904): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-09 00:51:19.196+0900 E/VCONF   ( 6904): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-09 00:51:19.236+0900 I/MY_LOG  ( 6904): change
04-09 00:51:19.987+0900 E/EFL     ( 6904): ecore_x<6904> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7817180
04-09 00:51:19.987+0900 I/MY_LOG  ( 6904): Button pressed
04-09 00:51:20.067+0900 E/EFL     ( 6904): ecore_x<6904> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7817257
04-09 00:51:20.067+0900 I/MY_LOG  ( 6904): Button unpressed
04-09 00:51:20.157+0900 E/EFL     ( 6904): elementary<6904> elc_naviframe.c:1715 _tizen_pop_effect() [DDO]
04-09 00:51:20.747+0900 E/EFL     ( 6904): ecore_x<6904> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7817942
04-09 00:51:20.847+0900 E/EFL     ( 6904): ecore_x<6904> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7818041
04-09 00:51:21.058+0900 W/CRASH_MANAGER( 6913): worker.c: worker_job(1199) > 1106904636c691491666680
04-09 00:51:21.078+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 6904 pgid = 6904
04-09 00:51:21.078+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(143) > dead_pid(6904)
04-09 00:51:21.078+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:51:21.108+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(3)
04-09 00:51:21.108+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-09 00:51:21.108+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-09 00:51:21.108+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(868)
04-09 00:51:21.108+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: fg
04-09 00:51:21.158+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: RESUME State: PAUSED
04-09 00:51:21.158+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-09 00:51:21.158+0900 E/cluster-home(  868): homescreen.cpp: OnResume(233) >  app resume
04-09 00:51:21.158+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:51:21.178+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-09 00:51:21.178+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-09 00:51:21.178+0900 E/AUL_PAD ( 1481): launchpad.c: main(698) > error reading sigchld info
04-09 00:51:21.178+0900 I/ESD     (  919): esd_main.c: __esd_app_dead_handler(1773) > pid: 6904
04-09 00:51:21.178+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 6904
04-09 00:51:21.178+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 6904
04-09 00:51:21.188+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.581
04-09 00:51:21.198+0900 E/weather-widget( 1410): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-09 00:51:21.198+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(0)
04-09 00:51:21.218+0900 I/Tizen::System( 1246): (259) > Active app [com.samsun], current [org.exampl] 
04-09 00:51:21.218+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:51:21.218+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-09 00:51:21.218+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-09 00:51:21.228+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:51:21.228+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-09 00:51:21.228+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-09 00:51:21.228+0900 I/Tizen::App( 1246): (243) > App[org.example.client] pid[6904] terminate event is forwarded
04-09 00:51:21.228+0900 I/Tizen::System( 1246): (256) > osp.accessorymanager.service provider is found.
04-09 00:51:21.228+0900 I/Tizen::System( 1246): (196) > Accessory Owner is removed [org.example.client, 6904, ]
04-09 00:51:21.228+0900 I/Tizen::System( 1246): (256) > osp.system.service provider is found.
04-09 00:51:21.228+0900 I/Tizen::App( 1246): (506) > TerminatedApp(org.example.client)
04-09 00:51:21.228+0900 I/Tizen::App( 1246): (512) > Not registered pid(6904)
04-09 00:51:21.228+0900 I/Tizen::System( 1246): (246) > Terminated app [org.example.client]
04-09 00:51:21.228+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-09 00:51:21.228+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:51:21.228+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:51:21.238+0900 I/Tizen::App( 1246): (782) > Finished invoking application event listener for org.example.client, 6904.
04-09 00:51:21.248+0900 E/weather-widget( 1410): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-09 00:51:21.268+0900 E/weather-common( 1410): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-09 00:51:21.338+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_create(409) > New handle created[0xb85e3288]
04-09 00:51:21.338+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_get_type(463) > Connected Network = 2
04-09 00:51:21.338+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_destroy(427) > Destroy handle: 0xb85e3288
04-09 00:51:21.338+0900 E/weather-common( 1410): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-09 00:51:21.338+0900 E/weather-widget( 1410): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-09 00:51:21.338+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-09 00:51:21.338+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-09 00:51:21.338+0900 W/AUL     ( 1410): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1410, appid: com.samsung.weather-m-widget, status: fg
04-09 00:51:23.340+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7820529
04-09 00:51:23.410+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7820606
04-09 00:51:23.420+0900 W/AUL     (  868): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-09 00:51:23.420+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 1
04-09 00:51:23.420+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 868
04-09 00:51:23.430+0900 E/RESOURCED(  684): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-09 00:51:23.430+0900 E/RESOURCED(  684): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-09 00:51:23.430+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
04-09 00:51:23.430+0900 W/AUL_PAD ( 1481): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-09 00:51:23.430+0900 W/AUL_PAD ( 1481): launchpad.c: __send_result_to_caller(267) > Check app launching
04-09 00:51:23.440+0900 I/abc     ( 6971): abc
04-09 00:51:23.440+0900 I/CAPI_APPFW_APPLICATION( 6971): app_main.c: ui_app_main(789) > app_efl_main
04-09 00:51:23.440+0900 I/CAPI_APPFW_APPLICATION( 6971): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-09 00:51:23.470+0900 E/TBM     ( 6971): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-09 00:51:23.530+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 6971, appid: org.example.client
04-09 00:51:23.530+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-09 00:51:23.530+0900 W/AUL     (  868): launch.c: app_request_to_launchpad(425) > request cmd(1) result(6971)
04-09 00:51:23.740+0900 D/basicui ( 6971): successed to load edc file
04-09 00:51:23.770+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:51:23.770+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:51:23.800+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-09 00:51:23.810+0900 I/Tizen::System( 1246): (259) > Active app [org.exampl], current [com.samsun] 
04-09 00:51:23.820+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:51:23.820+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:51:23.830+0900 I/MY_LOG  ( 6971): change
04-09 00:51:23.890+0900 I/APP_CORE( 6971): appcore-efl.c: __do_app(514) > [APP 6971] Event: RESET State: CREATED
04-09 00:51:23.890+0900 I/CAPI_APPFW_APPLICATION( 6971): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-09 00:51:23.900+0900 E/EFL     ( 6971): edje<6971> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:51:23.900+0900 E/EFL     ( 6971): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:51:23.910+0900 E/EFL     ( 6971): edje<6971> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:51:23.910+0900 E/EFL     ( 6971): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:51:23.910+0900 E/EFL     ( 6971): edje<6971> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:51:23.910+0900 E/EFL     ( 6971): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:51:23.920+0900 W/APP_CORE( 6971): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6c00002
04-09 00:51:23.920+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
04-09 00:51:24.051+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: PAUSE State: RUNNING
04-09 00:51:24.051+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-09 00:51:24.051+0900 E/cluster-home(  868): homescreen.cpp: OnPause(260) >  app pause
04-09 00:51:24.051+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(4)
04-09 00:51:24.051+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(868)
04-09 00:51:24.051+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: bg
04-09 00:51:24.051+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(6971) status(3)
04-09 00:51:24.061+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(6971)
04-09 00:51:24.061+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 6971, appid: org.example.client, status: fg
04-09 00:51:24.071+0900 I/APP_CORE( 6971): appcore-efl.c: __do_app(514) > [APP 6971] Event: RESUME State: CREATED
04-09 00:51:24.071+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-09 00:51:24.071+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-09 00:51:24.071+0900 W/AUL     ( 1410): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1410, appid: com.samsung.weather-m-widget, status: bg
04-09 00:51:24.081+0900 I/APP_CORE( 6971): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-09 00:51:24.081+0900 I/APP_CORE( 6971): appcore-efl.c: __do_app(625) > [APP 6971] Initial Launching, call the resume_cb
04-09 00:51:24.081+0900 I/CAPI_APPFW_APPLICATION( 6971): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-09 00:51:24.421+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(6971) status(0)
04-09 00:51:24.571+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.583
04-09 00:51:24.581+0900 I/Tizen::App( 1246): (499) > LaunchedApp(org.example.client)
04-09 00:51:24.581+0900 I/Tizen::App( 1246): (733) > Finished invoking application event listener for org.example.client, 6971.
04-09 00:51:25.382+0900 I/UXT     ( 7003): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-09 00:51:25.982+0900 E/EFL     ( 6971): ecore_x<6971> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7823172
04-09 00:51:26.093+0900 E/EFL     ( 6971): ecore_x<6971> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7823282
04-09 00:51:27.114+0900 E/EFL     ( 6971): ecore_x<6971> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7824308
04-09 00:51:27.124+0900 I/MY_LOG  ( 6971): Button pressed
04-09 00:51:27.224+0900 E/EFL     ( 6971): ecore_x<6971> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7824418
04-09 00:51:27.234+0900 E/VCONF   ( 6971): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-09 00:51:27.234+0900 E/VCONF   ( 6971): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-09 00:51:27.234+0900 E/VCONF   ( 6971): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-09 00:51:27.234+0900 E/VCONF   ( 6971): vconf.c: vconf_get_bool(2729) > vconf_get_bool(6971) : db/ise/keysound error
04-09 00:51:27.234+0900 E/VCONF   ( 6971): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-09 00:51:27.234+0900 E/VCONF   ( 6971): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-09 00:51:27.264+0900 I/MY_LOG  ( 6971): Button unpressed
04-09 00:51:27.354+0900 D/basicui ( 6971): successed to load edc file
04-09 00:51:27.374+0900 I/MY_LOG  ( 6971): change
04-09 00:51:28.815+0900 E/EFL     ( 6971): ecore_x<6971> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7826003
04-09 00:51:28.915+0900 E/EFL     ( 6971): ecore_x<6971> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7826102
04-09 00:51:29.065+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: MEM_FLUSH State: PAUSED
04-09 00:51:29.466+0900 E/EFL     ( 6971): ecore_x<6971> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7826651
04-09 00:51:29.576+0900 E/EFL     ( 6971): ecore_x<6971> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7826761
04-09 00:51:30.217+0900 E/EFL     ( 6971): ecore_x<6971> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7827415
04-09 00:51:30.217+0900 I/MY_LOG  ( 6971): Button pressed
04-09 00:51:30.317+0900 E/EFL     ( 6971): ecore_x<6971> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7827503
04-09 00:51:30.317+0900 I/MY_LOG  ( 6971): Button unpressed
04-09 00:51:30.337+0900 E/EFL     ( 6971): elementary<6971> elc_naviframe.c:1715 _tizen_pop_effect() [DDO]
04-09 00:51:34.030+0900 E/EFL     ( 6971): ecore_x<6971> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7831222
04-09 00:51:34.120+0900 E/EFL     ( 6971): ecore_x<6971> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7831310
04-09 00:51:34.170+0900 D/basicui ( 6971): successed to load edc file
04-09 00:51:34.190+0900 I/MY_LOG  ( 6971): change
04-09 00:51:34.200+0900 I/MY_LOG  ( 6971): change
04-09 00:51:34.220+0900 I/MY_LOG  ( 6971): change
04-09 00:51:34.941+0900 E/EFL     ( 6971): ecore_x<6971> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7832129
04-09 00:51:34.941+0900 I/MY_LOG  ( 6971): Button pressed
04-09 00:51:35.041+0900 E/EFL     ( 6971): ecore_x<6971> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7832228
04-09 00:51:35.041+0900 I/MY_LOG  ( 6971): Button unpressed
04-09 00:51:35.111+0900 E/EFL     ( 6971): elementary<6971> elc_naviframe.c:1715 _tizen_pop_effect() [DDO]
04-09 00:51:37.323+0900 W/CRASH_MANAGER( 6913): worker.c: worker_job(1199) > 1106971636c69149166669
